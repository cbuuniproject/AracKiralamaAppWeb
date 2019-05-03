using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web.Mvc;
using Bank.Commons.Concretes.Helpers;
using Bank.Commons.Concretes.Logger;
using BankAppWeb.Soap.CustomerService;
using BankAppWeb.Soap.SirketService;
using Customers = Bank.Models.Concretes.Customers;
using Transactions = Bank.Models.Concretes.Transactions;

namespace BankAppWeb.Soap.Controllers
{
    public class CustomerController : Controller
    {
        
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View(SelectCustomerByID(id));
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FormCollection collection)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                    if (InsertSirket(collection["SirketAdi"],collection["Sehir"],collection["Adres"]))
                       return RedirectToAction("ListAll");

                return View();
            }
            catch(Exception ex)
            {
                LogHelper.Log(LogTarget.File,ExceptionHelper.ExceptionToString(ex),true);
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                return View(SelectCustomerByID(id));
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("Customer doesn't exists.");
            }
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                if (UpdateCustomer(id, collection["CustomerName"],collection["CustomerSurname"],collection["CustomerPasskey"],decimal.Parse(collection["Balance"]),byte.Parse(collection["BalanceType"])))
                    return RedirectToAction("Index");

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                if (DeleteSirket(id))
                    return RedirectToAction("ListAll");
                return RedirectToAction("ListAll");
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("Operation failed!", ex);
            }
        }

        public ActionResult ListAll()
        {
            try
            {
                IList<Sirket> sirkets = ListAllCustomers().ToList();
                return View(sirkets);
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("Customer doesn't exists.");
            }
        }

        #region PRIVATE METHODS
        
        private bool InsertSirket(string sirketAdi, string sehir, string adres)
        {
            try
            {
                using (var sirketSoapClient = new SirketWebServiceSoapClient()) {
					return sirketSoapClient.InsertSirket(new SirketService.Sirket()
					{
						sirketAdi = sirketAdi,
						sirketPuani = 0,
						sehir=sehir,
						adres=adres
                    });
                 }
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("Customer doesn't exists.");
            }
        }

        private bool UpdateCustomer(int id, string name, string surname, string passkey, decimal balance, byte balancetype, bool isActive = true)
        {
            try
            {

                using (var customerSoapClient = new CustomerWebServiceSoapClient())
                {
                    return customerSoapClient.InsertCustomer(new CustomerService.Customers()
                    {
                        CustomerID = id,
                        CustomerName = name,
                        CustomerSurname = surname,
                        CustomerPasskey = passkey,
                        Balance = balance,
                        BalanceType = balancetype,
                        isActive = isActive
                    });
                }
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("Customer doesn't exists.");
            }
        }

        private bool DeleteSirket(int ID)
        {
            try
            {
                using (var sirketSoapClient = new SirketWebServiceSoapClient())
                {
                    return sirketSoapClient.DeleteSirket(ID);
                }
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("Customer doesn't exists.");
            }
        }

        private List<Sirket> ListAllCustomers()
        {
            try
            {
                using (var sirketSoapClient = new SirketWebServiceSoapClient())
                {
                    List<Sirket> sirkets = new List<Sirket>();
                    foreach (var responsedSirket in sirketSoapClient.SelectAllSirkets().OrderBy(x => x.sirketId).ToList())
                    {
                        Sirket castedSirket = new Sirket()
                        {
                            sirketAdi=responsedSirket.sirketAdi,
							sirketId=responsedSirket.sirketId,
							sehir=responsedSirket.sehir,
							adres=responsedSirket.adres,
							aracSayisi=responsedSirket.aracSayisi,
							sirketPuani=responsedSirket.sirketPuani
						};
                        sirkets.Add(castedSirket);
                    }
                    return sirkets;
                }
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("Customer doesn't exists.");
            }
        }

        private Customers SelectCustomerByID(int ID)
        {
            try
            {
                using (var customerSoapClient = new CustomerWebServiceSoapClient())
                {
                    Customers castedCustomer = null;
                    CustomerService.Customers responsedCustomer = customerSoapClient.SelectCustomerById(ID);
                    if (responsedCustomer != null)
                    {
                        castedCustomer = new Customers()
                        {
                            CustomerID = responsedCustomer.CustomerID,
                            CustomerName = responsedCustomer.CustomerName,
                            CustomerSurname = responsedCustomer.CustomerSurname,
                            CustomerPasskey = responsedCustomer.CustomerPasskey,
                            Balance = responsedCustomer.Balance,
                            BalanceType = responsedCustomer.BalanceType,
                            isActive = responsedCustomer.isActive
                        };
                        List<Transactions> castedTransactions = new List<Transactions>();
                        foreach (var responsedTransaction in responsedCustomer.Transactions)
                        {
                            castedTransactions.Add(new Transactions()
                            {
                                TransactorAccountNumber = responsedTransaction.TransactorAccountNumber,
                                TransactionDate = responsedTransaction.TransactionDate,
                                TransactionID = responsedTransaction.TransactionID,
                                ReceiverAccountNumber = responsedTransaction.ReceiverAccountNumber,
                                TransactionAmount = responsedTransaction.TransactionAmount,
                                Customer = castedCustomer,
                                isSuccess = responsedTransaction.isSuccess
                            });
                        }

                        castedCustomer.Transactions.AddRange(castedTransactions);
                    }

                    return castedCustomer;
                }
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File,ExceptionHelper.ExceptionToString(ex),true);
                throw new Exception("Customer doesn't exists.");
            }
        }

        #endregion
    }
}

using Bank.Commons.Concretes.Helpers;
using Bank.Commons.Concretes.Logger;
using Bank.Models.Concretes;
using BankAppWeb.Soap.KullaniciService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankAppWeb.Soap.Controllers
{
    public class KullaniciController : Controller
    {
        // GET: Kullanici
        public ActionResult Index()
        {
            return View();
        }


		// GET: Customer/Details/5
		/*public ActionResult Details(int id)
		{
			return View(SelectKullaniciByID(id));
		}*/

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
				if (InsertKullanici(collection["SirketAdi"], collection["Parola"], collection["KullaniciTuru"]))
					return RedirectToAction("ListAll");

				return View();
			}
			catch (Exception ex)
			{
				LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
				return View();
			}
		}

		// GET: Customer/Edit/5
		/*public ActionResult Edit(int id)
		{
			try
			{
				return View(SelectKullaniciByID(id));
			}
			catch (Exception ex)
			{
				LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
				throw new Exception("Customer doesn't exists.");
			}
		}*/

		// POST: Customer/Edit/5
		/*[HttpPost]
		public ActionResult Edit(int id, FormCollection collection)
		{
			if (!ModelState.IsValid)
			{
				return View();
			}
			try
			{
				if (UpdateCustomer(id, collection["CustomerName"], collection["CustomerSurname"], collection["CustomerPasskey"], decimal.Parse(collection["Balance"]), byte.Parse(collection["BalanceType"])))
					return RedirectToAction("Index");

				return View();
			}
			catch
			{
				return View();
			}
		}*/

		// GET: Customer/Delete/5
		public ActionResult Delete(int id)
		{
			try
			{
				if (DeleteKullanici(id))
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
				IList<Kullanici> sirkets = ListAllUsers().ToList();
				return View(sirkets);
			}
			catch (Exception ex)
			{
				LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
				throw new Exception("Customer doesn't exists.");
			}
		}

		#region PRIVATE METHODS

		private bool InsertKullanici(string kullaniciAdi, string parola, string kullaniciTuru)
		{
			try
			{
				using (var kullaniciSoapClient = new KullaniciWebServiceSoapClient())
				{
					return kullaniciSoapClient.InsertKullanici(new Kullanici()
					{
						kullaniciAd=kullaniciAdi,
						parola=parola,
						kullaniciTuru=kullaniciTuru
					});
				}
			}
			catch (Exception ex)
			{
				LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
				throw new Exception("Customer doesn't exists.");
			}
		}

		/*private bool UpdateCustomer(int id, string name, string surname, string passkey, decimal balance, byte balancetype, bool isActive = true)
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
		}*/

		private bool DeleteKullanici(int ID)
		{
			try
			{
				using (var kullaniciSoapClient = new KullaniciWebServiceSoapClient())
				{
					return kullaniciSoapClient.DeleteKullanici(ID);
				}
			}
			catch (Exception ex)
			{
				LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
				throw new Exception("Customer doesn't exists.");
			}
		}

		private List<Kullanici> ListAllUsers()
		{
			try
			{
				using (var kullaniciSoapClient = new KullaniciWebServiceSoapClient())
				{
					List<Kullanici> kullanicis = new List<Kullanici>();
					foreach (var responsedKullanici in kullaniciSoapClient.SelectAllKullanicis().OrderBy(x => x.kullaniciId).ToList())
					{
						Kullanici castedKullanici = new Kullanici()
						{
							kullaniciAd=responsedKullanici.kullaniciAd,
							kullaniciId=responsedKullanici.kullaniciId,
							kullaniciTuru=responsedKullanici.kullaniciTuru
						};
						kullanicis.Add(castedKullanici);
					}
					return kullanicis;
				}
			}
			catch (Exception ex)
			{
				LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
				throw new Exception("Customer doesn't exists.");
			}
		}

		/*private Customers SelectKullaniciByID(int ID)
		{
			try
			{
				using (var kullaniciSoapClient = new KullaniciWebServiceSoapClient())
				{
					Kullanici castedKullanici = null;
					CustomerService.Customers responsedCustomer = kullaniciSoapClient.SelectCustomerById(ID);
					if (responsedCustomer != null)
					{
						castedKullanici = new Customers()
						{
							
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
								Customer = castedKullanici,
								isSuccess = responsedTransaction.isSuccess
							});
						}

						castedKullanici.Transactions.AddRange(castedTransactions);
					}

					return castedKullanici;
				}
			}
			catch (Exception ex)
			{
				LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
				throw new Exception("Customer doesn't exists.");
			}
		}*/

		#endregion
	}
}
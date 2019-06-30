using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;
using System.Data.Entity.Validation;

namespace WebApplication1.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        //why we need this function? And when I comment this function, I cannot back to index page from form page
        public ActionResult Add()
        {
            var memberships = _context.MembershipTypes;

            var newcustomermembership = new CustomerMembershipViewModel()
            {
                Customer = new Customer(),
                MembershipTypes = memberships
            };
            return View("customerform", newcustomermembership);
        }

        [HttpPost]
        public ActionResult SaveAndUpdate(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerMembershipViewModel()
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };
                return View("CustomerForm", viewModel);
            }
            if(customer.Id == 0)
                 _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.Membership = customer.Membership;
                customerInDb.Birthday = customer.Birthday;
                customerInDb.IsSubscribeToNewsletter = customer.IsSubscribeToNewsletter;
            }

            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                Console.WriteLine(e);
            }

            return RedirectToAction("Index", "Customers");
        }


        //[Route("Customers")]
        public ActionResult Index()
        {
            var customerList = _context.Customers.Include(c => c.Membership);
            //using System.Data.Entity  Eager Loading
            return View(customerList);
        }

        public ActionResult Edit(int id)
        {
            //get customer with id from database
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerMembershipViewModel()
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };

            return View("CustomerForm", viewModel);
        }

        //public ActionResult Details(int id)
        //{
        //    var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
        //    if (customer == null)
        //        return HttpNotFound();
        //    return View(customer);
        //}
    }
}
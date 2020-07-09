using Day4_assignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day4_assignment.Repositories
{
    public class CustomerRepository
    {
        public CustomerContext db = new CustomerContext();
        public List<Customer> GetAll()
        {
            return db.customers.ToList(); 
        }
        public Customer GetEmployeeByID(string uid)
        {
            return db.customers.Find(uid);
        }
        public void Add(Customer c)
        {
            db.customers.Add(c);
            db.SaveChanges();
        }
        public void Modify(Customer c)
        {
            db.customers.Update(c);
            db.SaveChanges();
        }
        public void Delete(Customer c)
        {
            db.customers.Remove(c);
            db.SaveChanges();
        }
    }
}

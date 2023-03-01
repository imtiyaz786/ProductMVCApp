using System.Collections.Generic;

namespace shoppingAppMVC.Models
{
    public class Customers
    {
        public int CId { get; set; }
        public string CName { get; set; }
        public string CCity { get; set; }
        public double CWalletBalance { get; set; }
        public bool CIsActive { get; set; }

        static readonly List<Customers> cList = new List<Customers>()
        {
            new Customers() { CId=1, CName = "Imtiyaz", CCity = "Mumbai", CWalletBalance = 20000, CIsActive = true},
            new Customers() { CId=2, CName = "Abhinav", CCity = "Pune", CWalletBalance = 24000, CIsActive = false},
            new Customers() { CId=3, CName = "Manoj", CCity = "Kolkata", CWalletBalance = 40000, CIsActive = true},
            new Customers() { CId=4, CName = "Nikhil", CCity = "Noida", CWalletBalance = 10000, CIsActive = true},
            new Customers() { CId=5, CName = "Venugopal", CCity = "Hyderabad", CWalletBalance = 60000, CIsActive = true},
            new Customers() { CId=6, CName = "Harish", CCity = "Telangana", CWalletBalance = 70000, CIsActive = false}
        };

        public List<Customers> ShowCustomers()
        {
            return cList;
        }
    }
}

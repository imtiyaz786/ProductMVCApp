using System.Collections.Generic;

namespace shoppingAppMVC.Models
{
    public class Products
    {
        public int PId { get; set; }
        public string PName { get; set; }
        public string PCategory { get; set; }
        public double PPrice { get; set; }
        public bool PInStock { get; set; }
        
        static readonly List<Products> pList = new List<Products>()
        {
            new Products(){PId = 101, PName = "Pepsi", PCategory = "Cold-Drink", PPrice = 50, PInStock = true},
            new Products(){PId = 102, PName = "IPhone", PCategory = "Electronics", PPrice = 50000, PInStock = false},
            new Products(){PId = 103, PName = "Air-Pods", PCategory = "Electronics", PPrice = 5000, PInStock = true},
            new Products(){PId = 104, PName = "Maggie", PCategory = "FastFood", PPrice = 40, PInStock = true},
            new Products(){PId = 105, PName = "Pasta", PCategory = "FastFood", PPrice = 30, PInStock = false},
            new Products(){PId = 106, PName = "Appy", PCategory = "Drink", PPrice = 20, PInStock = true}

        };

        public List<Products> ShowProducts()
        {
            return pList;
        }
    }
}

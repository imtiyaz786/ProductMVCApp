# ProductMVCApp

- This is a simple asp.net mvc core project for products and customers.
- No database has been implemented for this project.
- Contains dummy data for customers and products within model classes.

Steps:

- Create an MVC core project.
- Add two models:
  - Customers.cs
    ```c#
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
    ```
  - Products.cs
    ```c#
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
    ```
- Add two controllers:
  - CustomersController.cs
    ```c#
    public class CustomersController : Controller
    {
        readonly Customers cObj = new Customers();

        public IActionResult ShowCustomers()
        {                                                                                                                                           
            return View(cObj.ShowCustomers());
        }
    }
    ```
  - ProductsController.cs
    ```c#
    public class ProductsController : Controller
    {
        readonly Products pObj = new Products();

        public IActionResult ShowProducts()
        {
            return View(pObj.ShowProducts());
        }
        
        public IActionResult Index()
        {
            return View();
        }
    }
    ```

- Add two views:
  - ShowCustomers.cshtml
  - ShowProducts.cshtml
    - Scaffold the view by right clicking on action method and adding view. 
    - You can select model class for the action you want to generate view template.
- Add navigation bar "Products" and "Customers" to the Home Page:
  - Under shared folder, add the below lines of code within _Layout.cshtml alongside Index and Privacy asp-action of Home asp-controller.
    ```html
     <li class="nav-item">
     <a class="nav-link text-dark" asp-area="" asp-controller="Products" asp-action="ShowProducts">Products</a>
    </li>
    <li class="nav-item">
     <a class="nav-link text-dark" asp-area="" asp-controller="Customers" asp-action="ShowCustomers">Customers</a>
    </li>
    ```
    
    Note: The application shows the Products and Customers table when the user clicks on Products or Customers navigation bar.
    UI for Products and Customers tables also contains hyperlink for create, edit and delete operation. These actions have not been implemented as this project only show the products and customers record.

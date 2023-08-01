namespace Northwind.WebApi.Model.Models
{
    public partial class SelectProductPagingResult
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }

        public string? ProductName { get; set; }

        public string? SupCompanyName { get; set; }

        public string? CategoryName { get; set; }
        public string? QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public Int16? UnitsInStock { get; set; }
        public Int16? UnitsOnOrder { get; set; }
        public Int16? ReorderLevel { get; set; }
        public string? Discontinued { get; set; }
        public int TotalRows { get; set; }
    }

   
}

﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.WebApi.Model.Models
{
    public partial class SelectOrdersDetailResult
    {
        public int OrderID { get; set; }
        public string ProductName { get; set; }
        public int ProductID { get; set; }
        public short? UnitsInStock { get; set; }
        public short? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public float? Discount { get; set; }
        public double? TotalSumm { get; set; }
    }
}
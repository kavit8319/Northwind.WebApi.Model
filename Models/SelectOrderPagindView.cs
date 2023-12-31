﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Northwind.WebApi.Model.Models;

[Keyless]
public partial class SelectOrderPagindView
{
    public int Id { get; set; }

    public int? EmployeeId { get; set; }

    public int? CustomerId { get; set; }

    public int? ShipVia { get; set; }

    [Required]
    [StringLength(40)]
    public string CompanyName { get; set; }

    [StringLength(30)]
    public string ContactName { get; set; }

    [Required]
    [StringLength(512)]
    public string EmplFullName { get; set; }

    [Column(TypeName = "money")]
    public decimal? Freight { get; set; }

    [StringLength(40)]
    public string ShipName { get; set; }

    [StringLength(60)]
    public string ShipAddress { get; set; }

    [StringLength(15)]
    public string Country { get; set; }

    [StringLength(15)]
    public string City { get; set; }

    [StringLength(10)]
    public string PostalCode { get; set; }

    [Required]
    [StringLength(40)]
    public string ShipCompanyName { get; set; }

    [StringLength(24)]
    public string ShipPhone { get; set; }

    public int? CountPositions { get; set; }

    public int? SummQuantity { get; set; }

    public double? TotalSumm { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RequiredDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ShippedDate { get; set; }
}
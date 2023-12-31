﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Northwind.WebApi.Model.Models;

[Index("CategoryName", Name = "CategoryName")]
public partial class Category
{
    [Key]
    [Column("CategoryID")]
    public int CategoryId { get; set; }

    [Required]
    [StringLength(150)]
    public string CategoryName { get; set; }

    [StringLength(256)]
    public string Description { get; set; }

    [Column(TypeName = "image")]
    public byte[] Picture { get; set; }

    [InverseProperty("Category")]
    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Northwind.WebApi.Model.Models;

[Keyless]
[Table("Adr_PostCodes")]
public partial class AdrPostCode
{
    public short CountryId { get; set; }

    [Required]
    [StringLength(50)]
    public string PostCode { get; set; }

    [StringLength(100)]
    public string AdminName1 { get; set; }

    [StringLength(100)]
    public string AdminName2 { get; set; }

    [StringLength(250)]
    public string PlaceName { get; set; }

    public int Id { get; set; }
}
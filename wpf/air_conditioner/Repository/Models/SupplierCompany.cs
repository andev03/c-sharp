﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class SupplierCompany
{
    public string SupplierId { get; set; }

    public string SupplierName { get; set; }

    public string SupplierDescription { get; set; }

    public string PlaceOfOrigin { get; set; }

    public virtual ICollection<AirConditioner> AirConditioners { get; set; } = new List<AirConditioner>();
}
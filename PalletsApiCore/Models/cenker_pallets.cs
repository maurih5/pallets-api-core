﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace PalletsApiCore.Models;

[Table("cenker_pallets", Schema = "web")]
public partial class cenker_pallets
{
    [Key]
    public Guid id { get; set; }

    [StringLength(13)]
    public string codigo { get; set; }

    [Column(TypeName = "character varying")]
    public string descripcion { get; set; }

    [Column(TypeName = "character varying")]
    public string fecha_alta { get; set; }
    [NotMapped]
    public List<Product> Products { get; set; }

}
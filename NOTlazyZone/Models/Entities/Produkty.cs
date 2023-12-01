using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NOTlazyZone.Models.Entities;

[Table("Produkty")]
public partial class Produkty
{
    [Key]
    [Column("pr_id")]
    public int PrId { get; set; }

    [Column("pr_nazwa")]
    [StringLength(50)]
    public string? PrNazwa { get; set; }

    [Column("pr_cena", TypeName = "decimal(10, 2)")]
    public decimal? PrCena { get; set; }

    [InverseProperty("ZaPr")]
    public virtual ICollection<Zamowienium> Zamowienia { get; set; } = new List<Zamowienium>();
}

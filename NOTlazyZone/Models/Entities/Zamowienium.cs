using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NOTlazyZone.Models.Entities;

public partial class Zamowienium
{
    [Key]
    [Column("za_id")]
    public int ZaId { get; set; }

    [Column("za_us_id")]
    public int? ZaUsId { get; set; }

    [Column("za_pr_id")]
    public int? ZaPrId { get; set; }

    [Column("za_ilosc")]
    public int? ZaIlosc { get; set; }

    [Column("za_data_zamowienia", TypeName = "datetime")]
    public DateTime? ZaDataZamowienia { get; set; }

    [ForeignKey("ZaPrId")]
    [InverseProperty("Zamowienia")]
    public virtual Produkty? ZaPr { get; set; }

    [ForeignKey("ZaUsId")]
    [InverseProperty("Zamowienia")]
    public virtual Uzytkownicy? ZaUs { get; set; }
}

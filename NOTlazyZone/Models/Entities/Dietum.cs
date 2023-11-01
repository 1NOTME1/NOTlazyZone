using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NOTlazyZone.Models.Entities;

public partial class Dietum
{
    [Key]
    [Column("da_id")]
    public int DaId { get; set; }

    [Column("da_nazwa")]
    [StringLength(255)]
    public string? DaNazwa { get; set; }

    [Column("da_us_id")]
    public int? DaUsId { get; set; }

    [Column("da_dat_id")]
    public int? DaDatId { get; set; }

    [Column("da_colorie")]
    public int? DaColorie { get; set; }

    [Column("da_ilosc_bialka")]
    public int? DaIloscBialka { get; set; }

    [Column("da_ilosc_weglowodanow")]
    public int? DaIloscWeglowodanow { get; set; }

    [Column("da_ilosc_tluszczy")]
    public int? DaIloscTluszczy { get; set; }

    [ForeignKey("DaDatId")]
    [InverseProperty("Dieta")]
    public virtual DietaTyp? DaDat { get; set; }

    [ForeignKey("DaUsId")]
    [InverseProperty("Dieta")]
    public virtual Uzytkownicy? DaUs { get; set; }
}

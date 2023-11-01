using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NOTlazyZone.Models.Entities;

public partial class Adre
{
    [Key]
    [Column("ad_id")]
    public int AdId { get; set; }

    [Column("ad_us_id")]
    public int? AdUsId { get; set; }

    [Column("ad_adt_id")]
    public int? AdAdtId { get; set; }

    [Column("ad_nazwa")]
    [StringLength(50)]
    public string? AdNazwa { get; set; }

    [Column("ad_opis")]
    [StringLength(255)]
    public string? AdOpis { get; set; }

    [Column("ad_uwagi")]
    [StringLength(255)]
    public string? AdUwagi { get; set; }

    [Column("ad_at_id")]
    public int? AdAtId { get; set; }

    [Column("ad_ulica")]
    [StringLength(200)]
    [Unicode(false)]
    public string? AdUlica { get; set; }

    [Column("ad_nr_domu")]
    [StringLength(20)]
    [Unicode(false)]
    public string? AdNrDomu { get; set; }

    [Column("ad_nr_lokalu")]
    [StringLength(20)]
    [Unicode(false)]
    public string? AdNrLokalu { get; set; }

    [Column("ad_kod")]
    [StringLength(10)]
    [Unicode(false)]
    public string? AdKod { get; set; }

    [Column("ad_miejscowosc")]
    [StringLength(200)]
    [Unicode(false)]
    public string? AdMiejscowosc { get; set; }

    [Column("ad_kto_dodal")]
    [StringLength(50)]
    public string? AdKtoDodal { get; set; }

    [Column("ad_kiedy_dodal", TypeName = "datetime")]
    public DateTime? AdKiedyDodal { get; set; }

    [Column("ad_kto_zmodyfikowal")]
    [StringLength(50)]
    public string? AdKtoZmodyfikowal { get; set; }

    [Column("ad_kiedy_zmodyfikowal", TypeName = "datetime")]
    public DateTime? AdKiedyZmodyfikowal { get; set; }

    [Column("ad_kto_usunal")]
    [StringLength(50)]
    public string? AdKtoUsunal { get; set; }

    [Column("ad_kiedy_usunal", TypeName = "datetime")]
    public DateTime? AdKiedyUsunal { get; set; }

    [Column("ad_aktywny")]
    public bool? AdAktywny { get; set; }

    [ForeignKey("AdAdtId")]
    [InverseProperty("Adres")]
    public virtual AdresTyp? AdAdt { get; set; }

    [ForeignKey("AdUsId")]
    [InverseProperty("Adres")]
    public virtual Uzytkownicy? AdUs { get; set; }

    [InverseProperty("StAd")]
    public virtual ICollection<StatystykiSilowni> StatystykiSilownis { get; set; } = new List<StatystykiSilowni>();
}

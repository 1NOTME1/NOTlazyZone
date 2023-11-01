using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NOTlazyZone.Models.Entities;

[Table("Telefon")]
public partial class Telefon
{
    [Key]
    [Column("tn_id")]
    public int TnId { get; set; }

    [Column("tn_us_id")]
    public int? TnUsId { get; set; }

    [Column("tn_numer")]
    [StringLength(50)]
    public string? TnNumer { get; set; }

    [Column("ad_opis")]
    [StringLength(255)]
    public string? AdOpis { get; set; }

    [Column("ad_uwagi")]
    [StringLength(255)]
    public string? AdUwagi { get; set; }

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

    [InverseProperty("StTn")]
    public virtual ICollection<StatystykiSilowni> StatystykiSilownis { get; set; } = new List<StatystykiSilowni>();

    [ForeignKey("TnUsId")]
    [InverseProperty("Telefons")]
    public virtual Uzytkownicy? TnUs { get; set; }
}

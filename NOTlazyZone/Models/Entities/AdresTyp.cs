using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NOTlazyZone.Models.Entities;

[Table("Adres_typ")]
public partial class AdresTyp
{
    [Key]
    [Column("adt_id")]
    public int AdtId { get; set; }

    [Column("adt_nazwa")]
    [StringLength(50)]
    [Unicode(false)]
    public string? AdtNazwa { get; set; }

    [Column("adt_kto_dodal")]
    [StringLength(50)]
    public string? AdtKtoDodal { get; set; }

    [Column("adt_kiedy_dodal", TypeName = "datetime")]
    public DateTime? AdtKiedyDodal { get; set; }

    [Column("adt_kto_zmodyfikowal")]
    [StringLength(50)]
    public string? AdtKtoZmodyfikowal { get; set; }

    [Column("adt_kiedy_zmodyfikowal", TypeName = "datetime")]
    public DateTime? AdtKiedyZmodyfikowal { get; set; }

    [Column("adt_kto_usunal")]
    [StringLength(50)]
    public string? AdtKtoUsunal { get; set; }

    [Column("adt_kiedy_usunal", TypeName = "datetime")]
    public DateTime? AdtKiedyUsunal { get; set; }

    [Column("adt_aktywny")]
    public bool? AdtAktywny { get; set; }

    [InverseProperty("AdAdt")]
    public virtual ICollection<Adre> Adres { get; set; } = new List<Adre>();
}

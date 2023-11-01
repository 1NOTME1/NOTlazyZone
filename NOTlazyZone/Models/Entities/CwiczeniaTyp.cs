using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NOTlazyZone.Models.Entities;

[Table("Cwiczenia_typ")]
public partial class CwiczeniaTyp
{
    [Key]
    [Column("cwt_id")]
    public int CwtId { get; set; }

    [Column("cwt_nazwa")]
    [StringLength(50)]
    public string? CwtNazwa { get; set; }

    [InverseProperty("CwCwt")]
    public virtual ICollection<Cwiczenium> Cwiczenia { get; set; } = new List<Cwiczenium>();
}

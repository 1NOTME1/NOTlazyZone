using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NOTlazyZone.Models.Entities;

public partial class Cwiczenium
{
    [Key]
    [Column("cw_id")]
    public int CwId { get; set; }

    [Column("cw_us_id")]
    public int? CwUsId { get; set; }

    [Column("cw_nazwa")]
    [StringLength(50)]
    public string? CwNazwa { get; set; }

    [Column("cw_cwt_id")]
    public int? CwCwtId { get; set; }

    [ForeignKey("CwCwtId")]
    [InverseProperty("Cwiczenia")]
    public virtual CwiczeniaTyp? CwCwt { get; set; }

    [ForeignKey("CwUsId")]
    [InverseProperty("Cwiczenia")]
    public virtual Uzytkownicy? CwUs { get; set; }

    [InverseProperty("PtCw")]
    public virtual ICollection<PlanTreningowy> PlanTreningowies { get; set; } = new List<PlanTreningowy>();

    [InverseProperty("StCw")]
    public virtual ICollection<StatystykiSilowni> StatystykiSilownis { get; set; } = new List<StatystykiSilowni>();
}

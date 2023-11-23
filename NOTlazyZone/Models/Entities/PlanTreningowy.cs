using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NOTlazyZone.Models.Entities;

[Table("PlanTreningowy")]
public partial class PlanTreningowy
{
    [Key]
    [Column("pt_id")]
    public int PtId { get; set; }

    [Column("pt_us_id")]
    public int? PtUsId { get; set; }

    [Column("pt_cw_id")]
    public int? PtCwId { get; set; }

    [Column("pt_czas")]
    public TimeSpan? PtCzas { get; set; }

    [Column("pt_trudnosc")]
    public int? PtTrudnosc { get; set; }

    [ForeignKey("PtCwId")]
    [InverseProperty("PlanTreningowies")]
    public virtual Cwiczenium? PtCw { get; set; }

    [ForeignKey("PtUsId")]
    [InverseProperty("PlanTreningowies")]
    public virtual Uzytkownicy? PtUs { get; set; }

    [InverseProperty("CwPt")]
    public virtual ICollection<Cwiczenium> Cwiczenia { get; set; } = new List<Cwiczenium>();

}

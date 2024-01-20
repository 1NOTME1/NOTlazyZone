using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NOTlazyZone.Models.Entities;

[Index("CwCwtId", Name = "IX_Cwiczenia_cw_cwt_id")]
[Index("CwUsId", Name = "IX_Cwiczenia_cw_us_id")]
public partial class Cwiczenium
{
    [Key]
    [Column("cw_id")]
    public int CwId { get; set; }

    [Column("cw_us_id")]
    public int CwUsId { get; set; }

    [Column("cw_nazwa")]
    [StringLength(50)]
    public string CwNazwa { get; set; }

    [Column("cw_cwt_id")]
    public int? CwCwtId { get; set; }

    [Column("cw_seria")]
    public int CwSeria { get; set; }

    [Column("cw_powtorzenie")]
    public int CwPowtorzenie { get; set; }

    [Column("cw_ciezar", TypeName = "decimal(10, 2)")]
    public decimal CwCiezar { get; set; }

    [Column("cw_przerwa", TypeName = "decimal(10, 2)")]
    public decimal CwPrzerwa { get; set; }

    [Column("cw_cardio")]
    public bool CwCardio { get; set; }

    [Column("cw_trudnosc")]
    public int CwTrudnosc { get; set; }

    [Column("cw_opis")]
    [Unicode(false)]
    public string? CwOpis { get; set; }

    [Column("cw_pt_id")]
    public int? CwPtId { get; set; }

    [ForeignKey("CwCwtId")]
    [InverseProperty("Cwiczenia")]
    public virtual CwiczeniaTyp CwCwt { get; set; }

    [ForeignKey("CwPtId")]
    [InverseProperty("Cwiczenia")]
    public virtual PlanTreningowy? CwPt { get; set; }

    [ForeignKey("CwUsId")]
    [InverseProperty("Cwiczenia")]
    public virtual Uzytkownicy? CwUs { get; set; }

    [InverseProperty("PtCw")]
    public virtual ICollection<PlanTreningowy> PlanTreningowies { get; set; } = new List<PlanTreningowy>();

    [InverseProperty("StCw")]
    public virtual ICollection<StatystykiSilowni> StatystykiSilownis { get; set; } = new List<StatystykiSilowni>();
}

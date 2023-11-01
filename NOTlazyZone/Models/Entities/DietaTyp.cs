using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NOTlazyZone.Models.Entities;

[Table("Dieta_typ")]
public partial class DietaTyp
{
    [Key]
    [Column("dat_id")]
    public int DatId { get; set; }

    [Column("dat_rodzaj")]
    [StringLength(50)]
    public string? DatRodzaj { get; set; }

    [Column("dat_us_id")]
    public int? DatUsId { get; set; }

    [ForeignKey("DatUsId")]
    [InverseProperty("DietaTyps")]
    public virtual Uzytkownicy? DatUs { get; set; }

    [InverseProperty("DaDat")]
    public virtual ICollection<Dietum> Dieta { get; set; } = new List<Dietum>();
}

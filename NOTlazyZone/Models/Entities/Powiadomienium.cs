using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NOTlazyZone.Models.Entities;

public partial class Powiadomienium
{
    [Key]
    [Column("po_id")]
    public int PoId { get; set; }

    [Column("po_us_id")]
    public int? PoUsId { get; set; }

    [Column("po_nazwa")]
    [StringLength(255)]
    public string? PoNazwa { get; set; }

    [Column("po_timestamp", TypeName = "datetime")]
    public DateTime? PoTimestamp { get; set; }

    [ForeignKey("PoUsId")]
    [InverseProperty("Powiadomienia")]
    public virtual Uzytkownicy? PoUs { get; set; }
}

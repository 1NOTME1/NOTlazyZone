using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NOTlazyZone.Models.Entities;

[Table("Kontakty")]
[Index("KoUsId", Name = "IX_Kontakty_ko_us_id")]
public partial class Kontakty
{
    [Key]
    [Column("ko_id")]
    public int KoId { get; set; }

    [Column("ko_us_id")]
    public int? KoUsId { get; set; }

    [ForeignKey("KoUsId")]
    [InverseProperty("Kontakties")]
    public virtual Uzytkownicy? KoUs { get; set; }
}

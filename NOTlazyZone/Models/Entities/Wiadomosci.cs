﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NOTlazyZone.Models.Entities;

[Table("Wiadomosci")]
public partial class Wiadomosci
{
    [Key]
    [Column("wi_id")]
    public int WiId { get; set; }

    [Column("wi_zawartosc")]
    [StringLength(255)]
    public string WiZawartosc { get; set; }

    [Column("wi_data_otrzymania", TypeName = "datetime")]
    public DateTime WiDataOtrzymania { get; set; }

    [Column("wi_do_osoby")]
    [StringLength(255)]
    public string WiDoOsoby { get; set; }

    [Column("wi_temat")]
    [StringLength(255)]
    public string WiTemat { get; set; }

    [Column("wi_us_id")]
    public int? WiUsId { get; set; }

    [ForeignKey("WiUsId")]
    [InverseProperty("Wiadomoscis")]
    public virtual Uzytkownicy? WiUs { get; set; }
}

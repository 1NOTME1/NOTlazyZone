using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NOTlazyZone.Models.Entities;

[Table("RolaUzytkownika")]
public partial class RolaUzytkownika
{
    [Key]
    [Column("ro_id")]
    public int RoId { get; set; }

    [Column("ro_RoleName")]
    [StringLength(50)]
    public string RoRoleName { get; set; }

    [InverseProperty("UsRo")]
    public virtual ICollection<Uzytkownicy> Uzytkownicies { get; set; } = new List<Uzytkownicy>();
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NOTlazyZone.Models.Entities;

[Index("MaUsId", Name = "IX_Mail_ma_us_id")]
public partial class Mail
{
    [Key]
    [Column("ma_id")]
    public int MaId { get; set; }

    [Column("ma_us_id")]
    public int? MaUsId { get; set; }

    [Column("ma_nazwa")]
    [StringLength(50)]
    public string? MaNazwa { get; set; }

    [Column("ma_opis")]
    [StringLength(255)]
    public string? MaOpis { get; set; }

    [Column("ma_uwagi")]
    [StringLength(255)]
    public string? MaUwagi { get; set; }

    [Column("ma_kto_dodal")]
    [StringLength(50)]
    public string? MaKtoDodal { get; set; }

    [Column("ma_kiedy_dodal", TypeName = "datetime")]
    public DateTime? MaKiedyDodal { get; set; }

    [Column("ma_kto_zmodyfikowal")]
    [StringLength(50)]
    public string? MaKtoZmodyfikowal { get; set; }

    [Column("ma_kiedy_zmodyfikowal", TypeName = "datetime")]
    public DateTime? MaKiedyZmodyfikowal { get; set; }

    [Column("ma_kto_usunal")]
    [StringLength(50)]
    public string? MaKtoUsunal { get; set; }

    [Column("ma_kiedy_usunal", TypeName = "datetime")]
    public DateTime? MaKiedyUsunal { get; set; }

    [Column("ma_aktywny")]
    public bool? MaAktywny { get; set; }

    [ForeignKey("MaUsId")]
    [InverseProperty("Mail")]
    public virtual Uzytkownicy? MaUs { get; set; }

    [InverseProperty("StMa")]
    public virtual ICollection<StatystykiSilowni> StatystykiSilownis { get; set; } = new List<StatystykiSilowni>();
}

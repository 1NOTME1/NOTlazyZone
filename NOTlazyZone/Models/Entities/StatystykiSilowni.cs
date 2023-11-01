using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NOTlazyZone.Models.Entities;

[Table("Statystyki_silowni")]
public partial class StatystykiSilowni
{
    [Key]
    [Column("st_id")]
    public int StId { get; set; }

    [Column("st_us_id")]
    public int? StUsId { get; set; }

    [Column("st_ad_id")]
    public int? StAdId { get; set; }

    [Column("st_tn_id")]
    public int? StTnId { get; set; }

    [Column("st_ma_id")]
    public int? StMaId { get; set; }

    [Column("st_cw_id")]
    public int? StCwId { get; set; }

    [Column("st_nazwa_silowni")]
    [StringLength(100)]
    public string? StNazwaSilowni { get; set; }

    [Column("st_wlasciciel")]
    [StringLength(50)]
    public string? StWlasciciel { get; set; }

    [Column("st_liczba_czlonkow")]
    public int? StLiczbaCzlonkow { get; set; }

    [Column("st_data_zalozenia", TypeName = "datetime")]
    public DateTime? StDataZalozenia { get; set; }

    [Column("st_strona_interentowa")]
    [StringLength(50)]
    public string? StStronaInterentowa { get; set; }

    [Column("st_godziny_otwarcia")]
    [StringLength(50)]
    public string? StGodzinyOtwarcia { get; set; }

    [Column("st_liczba_klientow")]
    public int? StLiczbaKlientow { get; set; }

    [Column("st_srednia_liczba_odwiedzin_tygodniowo")]
    public int? StSredniaLiczbaOdwiedzinTygodniowo { get; set; }

    [Column("st_najpopularniejsze_zajecia")]
    [StringLength(50)]
    public string? StNajpopularniejszeZajecia { get; set; }

    [Column("st_dostepni_trenerzy_personalni")]
    public bool? StDostepniTrenerzyPersonalni { get; set; }

    [Column("st_procentowy_wzrost_liczby_klientow")]
    public double? StProcentowyWzrostLiczbyKlientow { get; set; }

    [ForeignKey("StAdId")]
    [InverseProperty("StatystykiSilownis")]
    public virtual Adre? StAd { get; set; }

    [ForeignKey("StCwId")]
    [InverseProperty("StatystykiSilownis")]
    public virtual Cwiczenium? StCw { get; set; }

    [ForeignKey("StMaId")]
    [InverseProperty("StatystykiSilownis")]
    public virtual Mail? StMa { get; set; }

    [ForeignKey("StTnId")]
    [InverseProperty("StatystykiSilownis")]
    public virtual Telefon? StTn { get; set; }

    [ForeignKey("StUsId")]
    [InverseProperty("StatystykiSilownis")]
    public virtual Uzytkownicy? StUs { get; set; }
}

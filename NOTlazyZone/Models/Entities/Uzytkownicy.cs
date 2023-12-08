using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NOTlazyZone.Models.Entities;

[Table("Uzytkownicy")]
public partial class Uzytkownicy
{
    [Key]
    [Column("us_id")]
    public int UsId { get; set; }

    [Column("us_imie")]
    [StringLength(50)]
    public string UsImie { get; set; }

    [Column("us_nazwisko")]
    [StringLength(50)]
    public string UsNazwisko { get; set; }

    [Column("us_pesel")]
    [StringLength(11)]
    public string UsPesel { get; set; }

    [Column("us_data_rozpoczecia_od", TypeName = "datetime")]
    public DateTime UsDataRozpoczeciaOd { get; set; }

    [Column("us_data_zakonczenia_do", TypeName = "datetime")]
    public DateTime UsDataZakonczeniaDo { get; set; }

    [Column("us_opis")]
    [StringLength(255)]
    public string? UsOpis { get; set; }

    [Column("us_uwagi")]
    [StringLength(255)]
    public string? UsUwagi { get; set; }

    [Column("us_kto_dodal")]
    [StringLength(50)]
    public string? UsKtoDodal { get; set; }

    [Column("us_kiedy_dodal", TypeName = "datetime")]
    public DateTime? UsKiedyDodal { get; set; }

    [Column("us_kto_zmodyfikowal")]
    [StringLength(50)]
    public string? UsKtoZmodyfikowal { get; set; }

    [Column("us_kiedy_zmodyfikowal", TypeName = "datetime")]
    public DateTime? UsKiedyZmodyfikowal { get; set; }

    [Column("us_kto_usunal")]
    [StringLength(50)]
    public string? UsKtoUsunal { get; set; }

    [Column("us_kiedy_usunal", TypeName = "datetime")]
    public DateTime? UsKiedyUsunal { get; set; }

    [Column("us_aktywny")]
    public bool UsAktywny { get; set; }

    [Column("us_ro_id")]
    public int? UsRoId { get; set; }

    [InverseProperty("AdUs")]
    public virtual ICollection<Adre> Adres { get; set; } = new List<Adre>();

    [InverseProperty("CwUs")]
    public virtual ICollection<Cwiczenium> Cwiczenia { get; set; } = new List<Cwiczenium>();

    [InverseProperty("DaUs")]
    public virtual ICollection<Dietum> Dieta { get; set; } = new List<Dietum>();

    [InverseProperty("DatUs")]
    public virtual ICollection<DietaTyp> DietaTyps { get; set; } = new List<DietaTyp>();

    [InverseProperty("KoUs")]
    public virtual ICollection<Kontakty> Kontakties { get; set; } = new List<Kontakty>();

    [InverseProperty("MaUs")]
    public virtual ICollection<Mail> Mail { get; set; } = new List<Mail>();

    [InverseProperty("PtUs")]
    public virtual ICollection<PlanTreningowy> PlanTreningowies { get; set; } = new List<PlanTreningowy>();

    [InverseProperty("PoUs")]
    public virtual ICollection<Powiadomienium> Powiadomienia { get; set; } = new List<Powiadomienium>();

    [InverseProperty("StUs")]
    public virtual ICollection<StatystykiSilowni> StatystykiSilownis { get; set; } = new List<StatystykiSilowni>();

    [InverseProperty("TnUs")]
    public virtual ICollection<Telefon> Telefons { get; set; } = new List<Telefon>();

    [ForeignKey("UsRoId")]
    [InverseProperty("Uzytkownicies")]
    public virtual RolaUzytkownika? UsRo { get; set; }

    [InverseProperty("WiUs")]
    public virtual ICollection<Wiadomosci> Wiadomoscis { get; set; } = new List<Wiadomosci>();

    [InverseProperty("ZaUs")]
    public virtual ICollection<Zamowienium> Zamowienia { get; set; } = new List<Zamowienium>();
}

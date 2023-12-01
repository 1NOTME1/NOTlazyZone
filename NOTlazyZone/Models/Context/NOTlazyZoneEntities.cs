using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using NOTlazyZone.Models.Entities;

namespace NOTlazyZone.Models.Context;

public partial class NOTlazyZoneEntities : DbContext
{
    public NOTlazyZoneEntities()
    {
    }

    public NOTlazyZoneEntities(DbContextOptions<NOTlazyZoneEntities> options)
        : base(options)
    {
    }

    public virtual DbSet<Adre> Adres { get; set; }

    public virtual DbSet<AdresTyp> AdresTyps { get; set; }

    public virtual DbSet<CwiczeniaTyp> CwiczeniaTyps { get; set; }

    public virtual DbSet<Cwiczenium> Cwiczenia { get; set; }

    public virtual DbSet<DietaTyp> DietaTyps { get; set; }

    public virtual DbSet<Dietum> Dieta { get; set; }

    public virtual DbSet<Kontakty> Kontakties { get; set; }

    public virtual DbSet<Mail> Mail { get; set; }

    public virtual DbSet<PlanTreningowy> PlanTreningowies { get; set; }

    public virtual DbSet<Powiadomienium> Powiadomienia { get; set; }

    public virtual DbSet<Produkty> Produkties { get; set; }

    public virtual DbSet<RolaUzytkownika> RolaUzytkownikas { get; set; }

    public virtual DbSet<StatystykiSilowni> StatystykiSilownis { get; set; }

    public virtual DbSet<Telefon> Telefons { get; set; }

    public virtual DbSet<Uzytkownicy> Uzytkownicies { get; set; }

    public virtual DbSet<Wiadomosci> Wiadomoscis { get; set; }

    public virtual DbSet<Zamowienium> Zamowienia { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=NOTME\\SQLEXPRESS;TrustServerCertificate=True;Integrated Security=True;Database=NOTlazyZoneDBB");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Adre>(entity =>
        {
            entity.HasKey(e => e.AdId).HasName("PK__Adres__CAA4A627F4C1FCD8");

            entity.HasOne(d => d.AdAdt).WithMany(p => p.Adres).HasConstraintName("FK__Adres__ad_adt_id__2C3393D0");

            entity.HasOne(d => d.AdUs).WithMany(p => p.Adres).HasConstraintName("FK__Adres__ad_us_id__2B3F6F97");
        });

        modelBuilder.Entity<AdresTyp>(entity =>
        {
            entity.HasKey(e => e.AdtId).HasName("PK__Adres_ty__960EEA71EB04031F");
        });

        modelBuilder.Entity<CwiczeniaTyp>(entity =>
        {
            entity.HasKey(e => e.CwtId).HasName("PK__Cwiczeni__F647F12AF48F0513");
        });

        modelBuilder.Entity<Cwiczenium>(entity =>
        {
            entity.HasKey(e => e.CwId).HasName("PK__Cwiczeni__BDC9D0EDE1CADCC5");

            entity.HasOne(d => d.CwCwt).WithMany(p => p.Cwiczenia).HasConstraintName("FK__Cwiczenia__cw_cw__31EC6D26");

            entity.HasOne(d => d.CwPt).WithMany(p => p.Cwiczenia).HasConstraintName("FK_Cwiczenia_PlanTreningowy");

            entity.HasOne(d => d.CwUs).WithMany(p => p.Cwiczenia).HasConstraintName("FK__Cwiczenia__cw_us__30F848ED");
        });

        modelBuilder.Entity<DietaTyp>(entity =>
        {
            entity.HasKey(e => e.DatId).HasName("PK__Dieta_ty__92B5382919140F01");

            entity.HasOne(d => d.DatUs).WithMany(p => p.DietaTyps).HasConstraintName("FK__Dieta_typ__dat_u__3E52440B");
        });

        modelBuilder.Entity<Dietum>(entity =>
        {
            entity.HasKey(e => e.DaId).HasName("PK__Dieta__BF7A3295703554FA");

            entity.HasOne(d => d.DaDat).WithMany(p => p.Dieta).HasConstraintName("FK__Dieta__da_dat_id__4222D4EF");

            entity.HasOne(d => d.DaUs).WithMany(p => p.Dieta).HasConstraintName("FK__Dieta__da_us_id__412EB0B6");
        });

        modelBuilder.Entity<Kontakty>(entity =>
        {
            entity.HasKey(e => e.KoId).HasName("PK__Kontakty__21DD6918B8D87463");

            entity.HasOne(d => d.KoUs).WithMany(p => p.Kontakties).HasConstraintName("FK__Kontakty__ko_us___46E78A0C");
        });

        modelBuilder.Entity<Mail>(entity =>
        {
            entity.HasKey(e => e.MaId).HasName("PK__Mail__0FE166A71A240F6E");

            entity.HasOne(d => d.MaUs).WithMany(p => p.Mail).HasConstraintName("FK__Mail__ma_us_id__267ABA7A");
        });

        modelBuilder.Entity<PlanTreningowy>(entity =>
        {
            entity.HasKey(e => e.PtId).HasName("PK__PlanTren__5630B120E1102AA8");

            entity.HasOne(d => d.PtCw).WithMany(p => p.PlanTreningowies).HasConstraintName("FK__PlanTreni__pt_cw__5070F446");

            entity.HasOne(d => d.PtUs).WithMany(p => p.PlanTreningowies).HasConstraintName("FK__PlanTreni__pt_us__4F7CD00D");
        });

        modelBuilder.Entity<Powiadomienium>(entity =>
        {
            entity.HasKey(e => e.PoId).HasName("PK__Powiadom__368DA7F087DD48F9");

            entity.HasOne(d => d.PoUs).WithMany(p => p.Powiadomienia).HasConstraintName("FK__Powiadomi__po_us__534D60F1");
        });

        modelBuilder.Entity<Produkty>(entity =>
        {
            entity.HasKey(e => e.PrId).HasName("PK__Produkty__47B09F8E57558DFD");
        });

        modelBuilder.Entity<RolaUzytkownika>(entity =>
        {
            entity.HasKey(e => e.RoId).HasName("PK__RolaUzyt__55B52BD93F17149D");
        });

        modelBuilder.Entity<StatystykiSilowni>(entity =>
        {
            entity.HasKey(e => e.StId).HasName("PK__Statysty__A85E81CF574246AE");

            entity.HasOne(d => d.StAd).WithMany(p => p.StatystykiSilownis).HasConstraintName("FK__Statystyk__st_ad__38996AB5");

            entity.HasOne(d => d.StCw).WithMany(p => p.StatystykiSilownis).HasConstraintName("FK__Statystyk__st_cw__3B75D760");

            entity.HasOne(d => d.StMa).WithMany(p => p.StatystykiSilownis).HasConstraintName("FK__Statystyk__st_ma__3A81B327");

            entity.HasOne(d => d.StTn).WithMany(p => p.StatystykiSilownis).HasConstraintName("FK__Statystyk__st_tn__398D8EEE");

            entity.HasOne(d => d.StUs).WithMany(p => p.StatystykiSilownis).HasConstraintName("FK__Statystyk__st_us__37A5467C");
        });

        modelBuilder.Entity<Telefon>(entity =>
        {
            entity.HasKey(e => e.TnId).HasName("PK__Telefon__15DDCE4A8A2518F6");

            entity.HasOne(d => d.TnUs).WithMany(p => p.Telefons).HasConstraintName("FK__Telefon__tn_us_i__34C8D9D1");
        });

        modelBuilder.Entity<Uzytkownicy>(entity =>
        {
            entity.HasKey(e => e.UsId).HasName("PK__Uzytkown__2E701A67DAD1BDA5");

            entity.HasOne(d => d.UsRo).WithMany(p => p.Uzytkownicies).HasConstraintName("fk_role_id");
        });

        modelBuilder.Entity<Wiadomosci>(entity =>
        {
            entity.HasKey(e => e.WiId).HasName("PK__Wiadomos__0911F8635FE6D31F");

            entity.HasOne(d => d.WiUs).WithMany(p => p.Wiadomoscis).HasConstraintName("fk_wiadomosci_uzytkownicy");
        });

        modelBuilder.Entity<Zamowienium>(entity =>
        {
            entity.HasKey(e => e.ZaId).HasName("PK__Zamowien__3F240B44E6894367");

            entity.HasOne(d => d.ZaPr).WithMany(p => p.Zamowienia).HasConstraintName("FK__Zamowieni__za_pr__4CA06362");

            entity.HasOne(d => d.ZaUs).WithMany(p => p.Zamowienia).HasConstraintName("FK__Zamowieni__za_us__4BAC3F29");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

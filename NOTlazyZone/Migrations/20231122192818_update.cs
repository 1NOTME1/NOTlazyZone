using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NOTlazyZone.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Adres_typ",
            //    columns: table => new
            //    {
            //        adt_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        adt_nazwa = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        adt_kto_dodal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        adt_kiedy_dodal = table.Column<DateTime>(type: "datetime", nullable: true),
            //        adt_kto_zmodyfikowal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        adt_kiedy_zmodyfikowal = table.Column<DateTime>(type: "datetime", nullable: true),
            //        adt_kto_usunal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        adt_kiedy_usunal = table.Column<DateTime>(type: "datetime", nullable: true),
            //        adt_aktywny = table.Column<bool>(type: "bit", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Adres_ty__960EEA71EB04031F", x => x.adt_id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Cwiczenia_typ",
            //    columns: table => new
            //    {
            //        cwt_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        cwt_nazwa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Cwiczeni__F647F12AF48F0513", x => x.cwt_id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Produkty",
            //    columns: table => new
            //    {
            //        pr_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        pr_nazwa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        pr_cena = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Produkty__47B09F8E57558DFD", x => x.pr_id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Uzytkownicy",
            //    columns: table => new
            //    {
            //        us_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        us_imie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        us_nazwisko = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        us_pesel = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
            //        us_data_rozpoczecia_od = table.Column<DateTime>(type: "datetime", nullable: true),
            //        us_data_zakonczenia_do = table.Column<DateTime>(type: "datetime", nullable: true),
            //        us_opis = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        us_uwagi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        us_kto_dodal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        us_kiedy_dodal = table.Column<DateTime>(type: "datetime", nullable: true),
            //        us_kto_zmodyfikowal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        us_kiedy_zmodyfikowal = table.Column<DateTime>(type: "datetime", nullable: true),
            //        us_kto_usunal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        us_kiedy_usunal = table.Column<DateTime>(type: "datetime", nullable: true),
            //        us_aktywny = table.Column<bool>(type: "bit", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Uzytkown__2E701A67DAD1BDA5", x => x.us_id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Wiadomosci",
            //    columns: table => new
            //    {
            //        wi_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        wi_zawartosc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        wi_data_otrzymania = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Wiadomos__0911F8635FE6D31F", x => x.wi_id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Adres",
            //    columns: table => new
            //    {
            //        ad_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ad_us_id = table.Column<int>(type: "int", nullable: true),
            //        ad_adt_id = table.Column<int>(type: "int", nullable: true),
            //        ad_nazwa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ad_opis = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        ad_uwagi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        ad_at_id = table.Column<int>(type: "int", nullable: true),
            //        ad_ulica = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
            //        ad_nr_domu = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
            //        ad_nr_lokalu = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
            //        ad_kod = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
            //        ad_miejscowosc = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
            //        ad_kto_dodal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ad_kiedy_dodal = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ad_kto_zmodyfikowal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ad_kiedy_zmodyfikowal = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ad_kto_usunal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ad_kiedy_usunal = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ad_aktywny = table.Column<bool>(type: "bit", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Adres__CAA4A627F4C1FCD8", x => x.ad_id);
            //        table.ForeignKey(
            //            name: "FK__Adres__ad_adt_id__2C3393D0",
            //            column: x => x.ad_adt_id,
            //            principalTable: "Adres_typ",
            //            principalColumn: "adt_id");
            //        table.ForeignKey(
            //            name: "FK__Adres__ad_us_id__2B3F6F97",
            //            column: x => x.ad_us_id,
            //            principalTable: "Uzytkownicy",
            //            principalColumn: "us_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Cwiczenia",
            //    columns: table => new
            //    {
            //        cw_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        cw_us_id = table.Column<int>(type: "int", nullable: true),
            //        cw_nazwa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        cw_cwt_id = table.Column<int>(type: "int", nullable: true),
            //        cw_seria = table.Column<int>(type: "int", nullable: true),
            //        cw_powtorzenie = table.Column<int>(type: "int", nullable: true),
            //        cw_trudnosc = table.Column<int>(type: "int", nullable: true),
            //        cw_ciezar = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
            //        cw_przerwa = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
            //        cw_cardio = table.Column<bool>(type: "bit", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Cwiczeni__BDC9D0EDE1CADCC5", x => x.cw_id);
            //        table.ForeignKey(
            //            name: "FK__Cwiczenia__cw_cw__31EC6D26",
            //            column: x => x.cw_cwt_id,
            //            principalTable: "Cwiczenia_typ",
            //            principalColumn: "cwt_id");
            //        table.ForeignKey(
            //            name: "FK__Cwiczenia__cw_us__30F848ED",
            //            column: x => x.cw_us_id,
            //            principalTable: "Uzytkownicy",
            //            principalColumn: "us_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Dieta_typ",
            //    columns: table => new
            //    {
            //        dat_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        dat_rodzaj = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        dat_us_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Dieta_ty__92B5382919140F01", x => x.dat_id);
            //        table.ForeignKey(
            //            name: "FK__Dieta_typ__dat_u__3E52440B",
            //            column: x => x.dat_us_id,
            //            principalTable: "Uzytkownicy",
            //            principalColumn: "us_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Kontakty",
            //    columns: table => new
            //    {
            //        ko_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ko_us_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Kontakty__21DD6918B8D87463", x => x.ko_id);
            //        table.ForeignKey(
            //            name: "FK__Kontakty__ko_us___46E78A0C",
            //            column: x => x.ko_us_id,
            //            principalTable: "Uzytkownicy",
            //            principalColumn: "us_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Mail",
            //    columns: table => new
            //    {
            //        ma_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ma_us_id = table.Column<int>(type: "int", nullable: true),
            //        ma_nazwa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ma_opis = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        ma_uwagi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        ma_kto_dodal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ma_kiedy_dodal = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ma_kto_zmodyfikowal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ma_kiedy_zmodyfikowal = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ma_kto_usunal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ma_kiedy_usunal = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ma_aktywny = table.Column<bool>(type: "bit", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Mail__0FE166A71A240F6E", x => x.ma_id);
            //        table.ForeignKey(
            //            name: "FK__Mail__ma_us_id__267ABA7A",
            //            column: x => x.ma_us_id,
            //            principalTable: "Uzytkownicy",
            //            principalColumn: "us_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Powiadomienia",
            //    columns: table => new
            //    {
            //        po_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        po_us_id = table.Column<int>(type: "int", nullable: true),
            //        po_nazwa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        po_timestamp = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Powiadom__368DA7F087DD48F9", x => x.po_id);
            //        table.ForeignKey(
            //            name: "FK__Powiadomi__po_us__534D60F1",
            //            column: x => x.po_us_id,
            //            principalTable: "Uzytkownicy",
            //            principalColumn: "us_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "RolaUzytkownika",
            //    columns: table => new
            //    {
            //        ro_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ro_us_id = table.Column<int>(type: "int", nullable: true),
            //        ro_RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__RolaUzyt__55B52BD93F17149D", x => x.ro_id);
            //        table.ForeignKey(
            //            name: "FK__RolaUzytk__ro_us__5629CD9C",
            //            column: x => x.ro_us_id,
            //            principalTable: "Uzytkownicy",
            //            principalColumn: "us_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Telefon",
            //    columns: table => new
            //    {
            //        tn_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        tn_us_id = table.Column<int>(type: "int", nullable: true),
            //        tn_numer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ad_opis = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        ad_uwagi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        ad_kto_dodal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ad_kiedy_dodal = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ad_kto_zmodyfikowal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ad_kiedy_zmodyfikowal = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ad_kto_usunal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ad_kiedy_usunal = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ad_aktywny = table.Column<bool>(type: "bit", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Telefon__15DDCE4A8A2518F6", x => x.tn_id);
            //        table.ForeignKey(
            //            name: "FK__Telefon__tn_us_i__34C8D9D1",
            //            column: x => x.tn_us_id,
            //            principalTable: "Uzytkownicy",
            //            principalColumn: "us_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Zamowienia",
            //    columns: table => new
            //    {
            //        za_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        za_us_id = table.Column<int>(type: "int", nullable: true),
            //        za_pr_id = table.Column<int>(type: "int", nullable: true),
            //        za_ilosc = table.Column<int>(type: "int", nullable: true),
            //        za_data_zamowienia = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Zamowien__3F240B44E6894367", x => x.za_id);
            //        table.ForeignKey(
            //            name: "FK__Zamowieni__za_pr__4CA06362",
            //            column: x => x.za_pr_id,
            //            principalTable: "Produkty",
            //            principalColumn: "pr_id");
            //        table.ForeignKey(
            //            name: "FK__Zamowieni__za_us__4BAC3F29",
            //            column: x => x.za_us_id,
            //            principalTable: "Uzytkownicy",
            //            principalColumn: "us_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PlanTreningowy",
            //    columns: table => new
            //    {
            //        pt_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        pt_us_id = table.Column<int>(type: "int", nullable: true),
            //        pt_cw_id = table.Column<int>(type: "int", nullable: true),
            //        pt_czas = table.Column<TimeSpan>(type: "time", nullable: true),
            //        pt_trudnosc = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__PlanTren__5630B120E1102AA8", x => x.pt_id);
            //        table.ForeignKey(
            //            name: "FK__PlanTreni__pt_cw__5070F446",
            //            column: x => x.pt_cw_id,
            //            principalTable: "Cwiczenia",
            //            principalColumn: "cw_id");
            //        table.ForeignKey(
            //            name: "FK__PlanTreni__pt_us__4F7CD00D",
            //            column: x => x.pt_us_id,
            //            principalTable: "Uzytkownicy",
            //            principalColumn: "us_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Dieta",
            //    columns: table => new
            //    {
            //        da_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        da_nazwa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        da_us_id = table.Column<int>(type: "int", nullable: true),
            //        da_dat_id = table.Column<int>(type: "int", nullable: true),
            //        da_colorie = table.Column<int>(type: "int", nullable: true),
            //        da_ilosc_bialka = table.Column<int>(type: "int", nullable: true),
            //        da_ilosc_weglowodanow = table.Column<int>(type: "int", nullable: true),
            //        da_ilosc_tluszczy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Dieta__BF7A3295703554FA", x => x.da_id);
            //        table.ForeignKey(
            //            name: "FK__Dieta__da_dat_id__4222D4EF",
            //            column: x => x.da_dat_id,
            //            principalTable: "Dieta_typ",
            //            principalColumn: "dat_id");
            //        table.ForeignKey(
            //            name: "FK__Dieta__da_us_id__412EB0B6",
            //            column: x => x.da_us_id,
            //            principalTable: "Uzytkownicy",
            //            principalColumn: "us_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Statystyki_silowni",
            //    columns: table => new
            //    {
            //        st_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        st_us_id = table.Column<int>(type: "int", nullable: true),
            //        st_ad_id = table.Column<int>(type: "int", nullable: true),
            //        st_tn_id = table.Column<int>(type: "int", nullable: true),
            //        st_ma_id = table.Column<int>(type: "int", nullable: true),
            //        st_cw_id = table.Column<int>(type: "int", nullable: true),
            //        st_nazwa_silowni = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        st_wlasciciel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        st_liczba_czlonkow = table.Column<int>(type: "int", nullable: true),
            //        st_data_zalozenia = table.Column<DateTime>(type: "datetime", nullable: true),
            //        st_strona_interentowa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        st_godziny_otwarcia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        st_liczba_klientow = table.Column<int>(type: "int", nullable: true),
            //        st_srednia_liczba_odwiedzin_tygodniowo = table.Column<int>(type: "int", nullable: true),
            //        st_najpopularniejsze_zajecia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        st_dostepni_trenerzy_personalni = table.Column<bool>(type: "bit", nullable: true),
            //        st_procentowy_wzrost_liczby_klientow = table.Column<double>(type: "float", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Statysty__A85E81CF574246AE", x => x.st_id);
            //        table.ForeignKey(
            //            name: "FK__Statystyk__st_ad__38996AB5",
            //            column: x => x.st_ad_id,
            //            principalTable: "Adres",
            //            principalColumn: "ad_id");
            //        table.ForeignKey(
            //            name: "FK__Statystyk__st_cw__3B75D760",
            //            column: x => x.st_cw_id,
            //            principalTable: "Cwiczenia",
            //            principalColumn: "cw_id");
            //        table.ForeignKey(
            //            name: "FK__Statystyk__st_ma__3A81B327",
            //            column: x => x.st_ma_id,
            //            principalTable: "Mail",
            //            principalColumn: "ma_id");
            //        table.ForeignKey(
            //            name: "FK__Statystyk__st_tn__398D8EEE",
            //            column: x => x.st_tn_id,
            //            principalTable: "Telefon",
            //            principalColumn: "tn_id");
            //        table.ForeignKey(
            //            name: "FK__Statystyk__st_us__37A5467C",
            //            column: x => x.st_us_id,
            //            principalTable: "Uzytkownicy",
            //            principalColumn: "us_id");
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Adres_ad_adt_id",
            //    table: "Adres",
            //    column: "ad_adt_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Adres_ad_us_id",
            //    table: "Adres",
            //    column: "ad_us_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Cwiczenia_cw_cwt_id",
            //    table: "Cwiczenia",
            //    column: "cw_cwt_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Cwiczenia_cw_us_id",
            //    table: "Cwiczenia",
            //    column: "cw_us_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Dieta_da_dat_id",
            //    table: "Dieta",
            //    column: "da_dat_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Dieta_da_us_id",
            //    table: "Dieta",
            //    column: "da_us_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Dieta_typ_dat_us_id",
            //    table: "Dieta_typ",
            //    column: "dat_us_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Kontakty_ko_us_id",
            //    table: "Kontakty",
            //    column: "ko_us_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Mail_ma_us_id",
            //    table: "Mail",
            //    column: "ma_us_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PlanTreningowy_pt_cw_id",
            //    table: "PlanTreningowy",
            //    column: "pt_cw_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PlanTreningowy_pt_us_id",
            //    table: "PlanTreningowy",
            //    column: "pt_us_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Powiadomienia_po_us_id",
            //    table: "Powiadomienia",
            //    column: "po_us_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_RolaUzytkownika_ro_us_id",
            //    table: "RolaUzytkownika",
            //    column: "ro_us_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Statystyki_silowni_st_ad_id",
            //    table: "Statystyki_silowni",
            //    column: "st_ad_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Statystyki_silowni_st_cw_id",
            //    table: "Statystyki_silowni",
            //    column: "st_cw_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Statystyki_silowni_st_ma_id",
            //    table: "Statystyki_silowni",
            //    column: "st_ma_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Statystyki_silowni_st_tn_id",
            //    table: "Statystyki_silowni",
            //    column: "st_tn_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Statystyki_silowni_st_us_id",
            //    table: "Statystyki_silowni",
            //    column: "st_us_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Telefon_tn_us_id",
            //    table: "Telefon",
            //    column: "tn_us_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Zamowienia_za_pr_id",
            //    table: "Zamowienia",
            //    column: "za_pr_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Zamowienia_za_us_id",
            //    table: "Zamowienia",
            //    column: "za_us_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dieta");

            migrationBuilder.DropTable(
                name: "Kontakty");

            migrationBuilder.DropTable(
                name: "PlanTreningowy");

            migrationBuilder.DropTable(
                name: "Powiadomienia");

            migrationBuilder.DropTable(
                name: "RolaUzytkownika");

            migrationBuilder.DropTable(
                name: "Statystyki_silowni");

            migrationBuilder.DropTable(
                name: "Wiadomosci");

            migrationBuilder.DropTable(
                name: "Zamowienia");

            migrationBuilder.DropTable(
                name: "Dieta_typ");

            migrationBuilder.DropTable(
                name: "Adres");

            migrationBuilder.DropTable(
                name: "Cwiczenia");

            migrationBuilder.DropTable(
                name: "Mail");

            migrationBuilder.DropTable(
                name: "Telefon");

            migrationBuilder.DropTable(
                name: "Produkty");

            migrationBuilder.DropTable(
                name: "Adres_typ");

            migrationBuilder.DropTable(
                name: "Cwiczenia_typ");

            migrationBuilder.DropTable(
                name: "Uzytkownicy");
        }
    }
}

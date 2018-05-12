-------------------------------
-- Veritabanı Adı
-------------------------------
-- RabtBilDB.mdf

-------------------------------
-- Kullanicilar Tablosu
-------------------------------

CREATE TABLE [dbo].[Kullanicilar] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [KullaniciAdi] NVARCHAR (50) NULL,
    [Sifre]        NVARCHAR (32) NULL,
    [Adi]          NVARCHAR (50) NULL,
    [Soyadi]       NVARCHAR (50) NULL,
    [Eposta]       NVARCHAR (50) NULL,
    [Rol]          INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

-------------------------------
-- MusteriBilgileri Tablosu
-------------------------------

CREATE TABLE [dbo].[MusteriBilgileri] (
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [FormNo]           NVARCHAR (50)  NULL,
    [MusteriAdi]       NVARCHAR (50)  NULL,
    [Telefon]          NVARCHAR (16)  NULL,
    [UrunModeli]       NVARCHAR (50)  NULL,
    [UrunKodlari]      NVARCHAR (50)  NULL,
    [ArizaTanimi]      NVARCHAR (78)  NULL,
    [Aksesuarlar]      NVARCHAR (156) NULL,
    [EkBilgiler]       NVARCHAR (156) NULL,
    [UrunTakipNo]      NVARCHAR (50)  NULL,
    [UrunDurumu]       NVARCHAR (50)  NULL,
    [Ucret]            MONEY          NULL,
    [KaydiYapanID]     INT            NULL,
    [KayitTarihi]      DATETIME       NULL,
    [GuncelleyenID]    INT            NULL,
    [GuncellemeTarihi] DATETIME       NULL,
    [TeslimEdenID]     INT            NULL,
    [TeslimAlan]       NVARCHAR (50)  NULL,
    [TeslimTarihi]     DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [KM_Kullaniciler] FOREIGN KEY ([KaydiYapanID]) REFERENCES [dbo].[Kullanicilar] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE
);

-------------------------------
-- Varsayılan Kullanıcılar
-------------------------------

INSERT INTO [dbo].[Kullanicilar] ([KullaniciAdi], [Sifre], [Rol]) VALUES (N'1', N'C4CA4238A0B923820DCC509A6F75849B', 0)
INSERT INTO [dbo].[Kullanicilar] ([KullaniciAdi], [Sifre], [Rol]) VALUES (N'2', N'C4CA4238A0B923820DCC509A6F75849B', 1)
INSERT INTO [dbo].[Kullanicilar] ([KullaniciAdi], [Sifre], [Rol]) VALUES (N'3', N'C4CA4238A0B923820DCC509A6F75849B', 2)
-------------------------------
-- Veritabanı Adı
-------------------------------
-- RabtBilDB.mdf

-------------------------------
-- Kullanicilar Tablosu
-------------------------------

CREATE TABLE [dbo].[Kullanicilar] (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [KullaniciAdi] VARCHAR (30) NULL,
    [Sifre]        VARCHAR (30) NULL,
    [Adi]          VARCHAR (30) NULL,
    [Soyadi]       VARCHAR (30) NULL,
    [Eposta]       VARCHAR (30) NULL,
    [Rol]          INT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

-------------------------------
-- MusteriBilgileri Tablosu
-------------------------------

CREATE TABLE [dbo].[MusteriBilgileri] (
    [Id]               INT           IDENTITY (1, 1) NOT NULL,
    [FormNo]           VARCHAR (30)  NULL,
    [MusteriAdi]       VARCHAR (30)  NULL,
    [Telefon]          VARCHAR (16)  NULL,
    [UrunModeli]       VARCHAR (30)  NULL,
    [UrunKodlari]      VARCHAR (30)  NULL,
    [ArizaTanimi]      VARCHAR (78)  NULL,
    [Aksesuarlar]      VARCHAR (156) NULL,
    [EkBilgiler]       VARCHAR (156) NULL,
    [UrunTakipNo]      NVARCHAR (50) NULL,
    [UrunDurumu]       VARCHAR (30)  NULL,
    [Ucret]            MONEY         NULL,
    [KaydiYapanID]     INT           NULL,
    [KayitTarihi]      DATETIME      NULL,
    [GuncelleyenID]    INT           NULL,
    [GuncellemeTarihi] DATETIME      NULL,
    [TeslimEdenID]     INT           NULL,
    [TeslimAlan]       VARCHAR (30)  NULL,
    [TeslimTarihi]     DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [KM_Kullaniciler] FOREIGN KEY ([KaydiYapanID]) REFERENCES [dbo].[Kullanicilar] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE
);
-- Hekim tablosu
CREATE TABLE hekim (
    hekim_id SERIAL PRIMARY KEY,
    ad VARCHAR(50),
    soyad VARCHAR(50),
    uzmanlik_alani VARCHAR(100)
);
-- Hasta tablosu
CREATE TABLE hasta (
    hasta_id SERIAL PRIMARY KEY,
    ad VARCHAR(50),
    soyad VARCHAR(50),
    dogum_tarihi DATE,
    cinsiyet CHAR(1),
    telefon VARCHAR(20),
    eposta VARCHAR(100)
);
-- Randevu tablosu
CREATE TABLE randevu (
    randevu_id SERIAL PRIMARY KEY,
    hekim_id INT REFERENCES hekim(hekim_id),
    hasta_id INT REFERENCES hasta(hasta_id),
    randevu_tarihi TIMESTAMP,
    durum VARCHAR(20) -- örneğin: "Onaylandı", "İptal Edildi", "Tamamlandı" gibi durumlar olabilir
);
-- Tedavi tablosu
CREATE TABLE tedavi (
    tedavi_id SERIAL PRIMARY KEY,
    randevu_id INT REFERENCES randevu(randevu_id),
    tedavi_tarihi TIMESTAMP,
    aciklama TEXT,
    uygulanan_islemler TEXT
);
-- Reçete tablosu
CREATE TABLE recete (
    recete_id SERIAL PRIMARY KEY,
    randevu_id INT REFERENCES randevu(randevu_id),
    olusturma_tarihi TIMESTAMP,
    ilac_ad VARCHAR(100),
    dozaj VARCHAR(50),
    kullanim_sikligi VARCHAR(50),
    aciklama TEXT
);
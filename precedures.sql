-- CREATE OR REPLACE PROCEDURE Tedavi_Kaydet(
--     randevu_id int,
--     tedavi_tarihi date,
--     aciklama varchar,
--     uygulanan_islemler varchar
-- )
-- AS $$
-- BEGIN
--     INSERT INTO tedavi (randevu_id, tedavi_tarihi, aciklama, uygulanan_islemler)
--     VALUES (randevu_id, tedavi_tarihi, aciklama, uygulanan_islemler);
-- END;
-- $$ LANGUAGE plpgsql;

CREATE OR REPLACE PROCEDURE Hasta_Kaydet(
    hasta_id int,
	ad varchar,
	soyad varchar,
	dogum_tarihi date,
	cinsiyet varchar,
    telefon varchar,
    eposta varchar
)
AS $$
BEGIN
    INSERT INTO hasta(hasta_id, ad, soyad, dogum_tarihi, cinsiyet, telefon, eposta)
    VALUES (hasta_id, ad, soyad, dogum_tarihi, cinsiyet, telefon, eposta);
END;
$$ LANGUAGE plpgsql;


CREATE OR REPLACE PROCEDURE HekimKaydet(
    hekim_id int,
	ad varchar,
	soyad varchar,
    uzmanlik_alani varchar
)
AS $$
BEGIN
    INSERT INTO hekim(hekim_id, ad, soyad,uzmanlik_alani )
    VALUES (hekim_id, ad, soyad,uzmanlik_alani);
END;
$$ LANGUAGE plpgsql;


CREATE OR REPLACE PROCEDURE Randevu_Kaydet(
	randevu_id int,
    hekim_id int,
    hasta_id int,
    tedavi_id int,
    randevu_tarihi date,
    randevu_saati time without time zone,
    durum  varchar
)
AS $$
BEGIN
    -- Prosedürün işlemleri burada yer alır
    INSERT INTO randevu (randevu_id, hekim_id, hasta_id, tedavi_id, randevu_tarihi, randevu_saati, durum)
    VALUES (randevu_id, hekim_id, hasta_id, tedavi_id, randevu_tarihi, randevu_saati, durum);
END;
$$ LANGUAGE plpgsql;

--------------------------
CREATE OR REPLACE PROCEDURE recete_kaydet(
	recete_id int,
    randevu_id int,
    olusturma_tarihi date,
    ilac_ad varchar,
    dozaj varchar,
    kullanim_sikligi decimal,
    aciklama varchar,
	hasta_id int
)
AS $$
BEGIN
    -- Prosedürün işlemleri burada yer alır
    INSERT INTO recete (recete_id, randevu_id, olusturma_tarihi, ilac_ad, dozaj, kullanim_sikligi, aciklama,hasta_id)
    VALUES (recete_id, randevu_id, olusturma_tarihi, ilac_ad, dozaj, kullanim_sikligi, aciklama,hasta_id);
END;
$$ LANGUAGE plpgsql;

-----------
select * from recete

---------silme işlemleri------------
CREATE OR REPLACE PROCEDURE Randevu_Sil(
    randevu_id int
)
AS $$
BEGIN
    -- Prosedürün işlemleri burada yer alır
    DELETE FROM randevu WHERE randevu_id = Randevu_Sil.randevu_id;
END;
$$ LANGUAGE plpgsql;
--------recete sil
CREATE OR REPLACE PROCEDURE recete_sil(
    p_recete_id int
)
AS $$
BEGIN
    -- Prosedürün işlemleri burada yer alır
    DELETE FROM recete WHERE recete_id = p_recete_id;
END;
$$ LANGUAGE plpgsql;

-------------silme--------

CREATE OR REPLACE PROCEDURE Hekim_Sil(
    p_hekim_id int
)
AS $$
BEGIN
    -- Prosedürün işlemleri burada yer alır
    DELETE FROM hekim WHERE hekim_id = p_hekim_id;
END;
$$ LANGUAGE plpgsql;

----güncelle hekim----
CREATE OR REPLACE PROCEDURE Hekim_Guncelle(
    p_hekim_id int,
    p_ad varchar,
    p_soyad varchar,
    p_uzmanlik_alani varchar
)
AS $$
BEGIN
    UPDATE hekim
    SET ad = p_ad,
        soyad = p_soyad,
        uzmanlik_alani = p_uzmanlik_alani
    WHERE hekim_id = p_hekim_id;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE PROCEDURE Sil_Randevular_By_Hekim_ID(p_hekim_id int)
AS $$
BEGIN
    DELETE FROM randevu WHERE hekim_id = p_hekim_id;
END;
$$ LANGUAGE plpgsql;

--------ilişkileri düzenle
ALTER TABLE randevu
ADD CONSTRAINT fk_randevu_hekim_id
FOREIGN KEY (hekim_id)
REFERENCES hekim(hekim_id)
ON DELETE CASCADE
ON UPDATE CASCADE;

--------------
ALTER TABLE tedavi
DROP CONSTRAINT IF EXISTS tedavi_randevu_id_fkey;

ALTER TABLE tedavi
ADD CONSTRAINT tedavi_randevu_id_fkey
FOREIGN KEY (randevu_id)
REFERENCES randevu(randevu_id)
ON DELETE CASCADE;

------------randevu silmek için-----
CREATE OR REPLACE PROCEDURE Randevu_Sil(
    p_randevu_id int
)
AS $$
BEGIN
    -- İlgili "tedavi" kayıtlarını sil
    DELETE FROM tedavi WHERE randevu_id = p_randevu_id;
    
    -- "randevu" tablosundaki ilgili kaydı sil
    DELETE FROM randevu WHERE randevu_id = p_randevu_id;
END;
$$ LANGUAGE plpgsql;

-----------hekim_sil






CREATE OR REPLACE PROCEDURE Hekim_Sil(
    p_hekim_id int
)
AS $$
BEGIN
    -- İlgili "recete" kayıtlarını sil (ilgili randevulara bağlı olanlar)
    DELETE FROM recete WHERE randevu_id IN (SELECT randevu_id FROM randevu WHERE hekim_id = p_hekim_id);
    
    -- İlgili "tedavi" kayıtlarını sil (ilgili randevulara bağlı olanlar)
    DELETE FROM tedavi WHERE randevu_id IN (SELECT randevu_id FROM randevu WHERE hekim_id = p_hekim_id);
    
    -- İlgili "randevu" kayıtlarını sil
    DELETE FROM randevu WHERE hekim_id = p_hekim_id;
    
    -- "hekim" tablosundaki ilgili kaydı sil
    DELETE FROM hekim WHERE hekim_id = p_hekim_id;
END;
$$ LANGUAGE plpgsql;

-----------------Hasta sil
CREATE OR REPLACE PROCEDURE Hasta_Sil(
    p_hasta_id int
)
AS $$
BEGIN
    -- İlgili "recete" kayıtlarını sil (ilgili randevulara bağlı olanlar)
    DELETE FROM recete WHERE randevu_id IN (SELECT randevu_id FROM randevu WHERE hasta_id = p_hasta_id);
    
    -- İlgili "tedavi" kayıtlarını sil (ilgili randevulara bağlı olanlar)
    DELETE FROM tedavi WHERE randevu_id IN (SELECT randevu_id FROM randevu WHERE hasta_id = p_hasta_id);
    
    -- İlgili "randevu" kayıtlarını sil
    DELETE FROM randevu WHERE hasta_id = p_hasta_id;
    
    -- "hasta" tablosundaki ilgili kaydı sil
    DELETE FROM hasta WHERE hasta_id = p_hasta_id;
END;
$$ LANGUAGE plpgsql;

-----------hasta_guncelle----------------
CREATE OR REPLACE PROCEDURE Hasta_Guncelle(
    p_hasta_id int,
    p_ad varchar,
    p_soyad varchar,
    p_dogum_tarihi date,
    p_cinsiyet varchar,
    p_telefon varchar,
    p_eposta varchar
)
AS $$
BEGIN
    -- Hasta bilgilerini güncelle
    UPDATE hasta
    SET ad = p_ad,
        soyad = p_soyad,
        dogum_tarihi = p_dogum_tarihi,
        cinsiyet = p_cinsiyet,
        telefon = p_telefon,
        eposta = p_eposta
    WHERE hasta_id = p_hasta_id;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE PROCEDURE Sil_Randevular_By_Hasta_ID(p_hasta_id int)
AS $$
BEGIN
    -- İlgili "recete" kayıtlarını sil (ilgili hastaya atanmış randevulara bağlı olanlar)
    DELETE FROM recete WHERE randevu_id IN (SELECT randevu_id FROM randevu WHERE hasta_id = p_hasta_id);
    
    -- İlgili "tedavi" kayıtlarını sil (ilgili hastaya atanmış randevulara bağlı olanlar)
    DELETE FROM tedavi WHERE randevu_id IN (SELECT randevu_id FROM randevu WHERE hasta_id = p_hasta_id);
    
    -- İlgili "randevu" kayıtlarını sil
    DELETE FROM randevu WHERE hasta_id = p_hasta_id;
END;
$$ LANGUAGE plpgsql;


-------------VİEW ----
CREATE OR REPLACE VIEW Recete_View AS
SELECT
       hasta.ad AS hasta_ad,
	   c.olusturma_tarihi,
	   c.ilac_ad,
	   c.dozaj,
	   c.kullanim_sikligi,
       c.aciklama
   
FROM recete c

INNER JOIN hasta ON c.hasta_id = hasta.hasta_id

--------------randevu güncelle

CREATE OR REPLACE PROCEDURE randevu_guncelle(
    p_randevu_id int,
    p_hekim_id int,
    p_hasta_id int,
    p_tedavi_id int,
    p_randevu_tarihi date,
    p_randevu_saati time without time zone,
    p_durum varchar
)
AS $$
BEGIN
    -- Belirtilen randevu_id'ye sahip kaydı güncelle
    UPDATE randevu
    SET 
        hekim_id = p_hekim_id,
        hasta_id = p_hasta_id,
        tedavi_id = p_tedavi_id,
        randevu_tarihi = p_randevu_tarihi,
        randevu_saati = p_randevu_saati,
        durum = p_durum
    WHERE randevu_id = p_randevu_id;
END;
$$ LANGUAGE plpgsql;
	 

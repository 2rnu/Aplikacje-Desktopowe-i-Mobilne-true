-- Tworzenie tabeli zgodnie z danymi z tabeli
CREATE TABLE Lekcje (
    email VARCHAR(100) PRIMARY KEY,
    nazwisko_ucznia VARCHAR(50),
    tytul_lekcji VARCHAR(100),
    id INT,
    nazwa_kursu VARCHAR(100),
    instruktor VARCHAR(100),
    imie_ucznia VARCHAR(50),
    specjalizacja VARCHAR(50),
    data_urodzenia DATE,
    adres_ucznia VARCHAR(100),
    autor_lekcji VARCHAR(100)
);

-- Wstawianie danych
INSERT INTO Lekcje (email, nazwisko_ucznia, tytul_lekcji, id, nazwa_kursu, instruktor, imie_ucznia, specjalizacja, data_urodzenia, adres_ucznia, autor_lekcji) VALUES 
('J.Nowak@wp.pl', 'Nowak', 'wstęp', 1, 'C#', 'Piotr Wiśniewski', 'Jan', NULL, '1983-10-10', 'Kielce', 'Jan Kowalski'),
('Anna@wp.pl', 'Nieznane', 'podstawy obrazów', 2, 'Photoshop', 'Anna Lis', 'Anna', 'grafika', '2000-11-11', 'Warszawa', 'Ewa Nowak');

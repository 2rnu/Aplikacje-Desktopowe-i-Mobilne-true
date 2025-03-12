-- Tworzenie tabel bez dodatkowych ID
CREATE TABLE Uczniowie (
    email VARCHAR(100) PRIMARY KEY,
    imie VARCHAR(50),
    nazwisko VARCHAR(50),
    data_urodzenia DATE,
    adres VARCHAR(100),
    specjalizacja VARCHAR(50)
);

CREATE TABLE Kursy (
    nazwa VARCHAR(100) PRIMARY KEY
);

CREATE TABLE Instruktorzy (
    imie VARCHAR(50),
    nazwisko VARCHAR(50),
    PRIMARY KEY (imie, nazwisko)
);

CREATE TABLE Autorzy (
    imie VARCHAR(50),
    nazwisko VARCHAR(50),
    PRIMARY KEY (imie, nazwisko)
);

CREATE TABLE Lekcje (
    tytul VARCHAR(100) PRIMARY KEY,
    nazwa_kursu VARCHAR(100),
    instruktor_imie VARCHAR(50),
    instruktor_nazwisko VARCHAR(50),
    autor_imie VARCHAR(50),
    autor_nazwisko VARCHAR(50),
    FOREIGN KEY (nazwa_kursu) REFERENCES Kursy(nazwa),
    FOREIGN KEY (instruktor_imie, instruktor_nazwisko) REFERENCES Instruktorzy(imie, nazwisko),
    FOREIGN KEY (autor_imie, autor_nazwisko) REFERENCES Autorzy(imie, nazwisko)
);

CREATE TABLE Uczniowie_Lekcje (
    email VARCHAR(100),
    tytul_lekcji VARCHAR(100),
    PRIMARY KEY (email, tytul_lekcji),
    FOREIGN KEY (email) REFERENCES Uczniowie(email),
    FOREIGN KEY (tytul_lekcji) REFERENCES Lekcje(tytul)
);

-- Wstawianie danych
INSERT INTO Uczniowie (email, imie, nazwisko, data_urodzenia, adres, specjalizacja) VALUES 
('J.Nowak@wp.pl', 'Jan', 'Nowak', '1983-10-10', 'Kielce', NULL),
('Anna@wp.pl', 'Anna', 'Nieznane', '2000-11-11', 'Warszawa', 'grafika');

INSERT INTO Kursy (nazwa) VALUES 
('C#'),
('Photoshop');

INSERT INTO Instruktorzy (imie, nazwisko) VALUES 
('Piotr', 'Wiśniewski'),
('Anna', 'Lis');

INSERT INTO Autorzy (imie, nazwisko) VALUES 
('Jan', 'Kowalski'),
('Ewa', 'Nowak');

INSERT INTO Lekcje (tytul, nazwa_kursu, instruktor_imie, instruktor_nazwisko, autor_imie, autor_nazwisko) VALUES 
('wstęp', 'C#', 'Piotr', 'Wiśniewski', 'Jan', 'Kowalski'),
('podstawy obrazów', 'Photoshop', 'Anna', 'Lis', 'Ewa', 'Nowak');

INSERT INTO Uczniowie_Lekcje (email, tytul_lekcji) VALUES 
('J.Nowak@wp.pl', 'wstęp'),
('Anna@wp.pl', 'podstawy obrazów');

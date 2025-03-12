-- Tworzenie tabel
CREATE TABLE Uczniowie (
    id_ucznia INT PRIMARY KEY AUTO_INCREMENT,
    imie VARCHAR(50),
    nazwisko VARCHAR(50),
    email VARCHAR(100) UNIQUE,
    data_urodzenia DATE,
    adres VARCHAR(100),
    specjalizacja VARCHAR(50)
);

CREATE TABLE Kursy (
    id_kursu INT PRIMARY KEY AUTO_INCREMENT,
    nazwa VARCHAR(100)
);

CREATE TABLE Instruktorzy (
    id_instruktora INT PRIMARY KEY AUTO_INCREMENT,
    imie VARCHAR(50),
    nazwisko VARCHAR(50)
);

CREATE TABLE Autorzy (
    id_autora INT PRIMARY KEY AUTO_INCREMENT,
    imie VARCHAR(50),
    nazwisko VARCHAR(50)
);

CREATE TABLE Lekcje (
    id_lekcji INT PRIMARY KEY AUTO_INCREMENT,
    tytul VARCHAR(100),
    id_kursu INT,
    id_instruktora INT,
    id_autora INT,
    FOREIGN KEY (id_kursu) REFERENCES Kursy(id_kursu),
    FOREIGN KEY (id_instruktora) REFERENCES Instruktorzy(id_instruktora),
    FOREIGN KEY (id_autora) REFERENCES Autorzy(id_autora)
);

CREATE TABLE Uczniowie_Lekcje (
    id_ucznia INT,
    id_lekcji INT,
    PRIMARY KEY (id_ucznia, id_lekcji),
    FOREIGN KEY (id_ucznia) REFERENCES Uczniowie(id_ucznia),
    FOREIGN KEY (id_lekcji) REFERENCES Lekcje(id_lekcji)
);

-- Wstawianie danych
INSERT INTO Uczniowie (imie, nazwisko, email, data_urodzenia, adres, specjalizacja) VALUES 
('Jan', 'Nowak', 'J.Nowak@wp.pl', '1983-10-10', 'Kielce', NULL),
('Anna', 'Nieznane', 'Anna@wp.pl', '2000-11-11', 'Warszawa', 'grafika');

INSERT INTO Kursy (nazwa) VALUES 
('C#'),
('Photoshop');

INSERT INTO Instruktorzy (imie, nazwisko) VALUES 
('Piotr', 'Wiśniewski'),
('Anna', 'Lis');

INSERT INTO Autorzy (imie, nazwisko) VALUES 
('Jan', 'Kowalski'),
('Ewa', 'Nowak');

INSERT INTO Lekcje (tytul, id_kursu, id_instruktora, id_autora) VALUES 
('wstęp', 1, 1, 1),
('podstawy obrazów', 2, 2, 2);

INSERT INTO Uczniowie_Lekcje (id_ucznia, id_lekcji) VALUES 
(1, 1),
(2, 2);

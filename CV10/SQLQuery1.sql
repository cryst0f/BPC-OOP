--0
DROP TABLE IF EXISTS Hodnoceni;
DROP TABLE IF EXISTS ZapsanePredmety;
DROP TABLE IF EXISTS Studenti;
DROP TABLE IF EXISTS Predmety;

--2
CREATE TABLE Predmety(
	Zkratka VARCHAR(10) NOT NULL PRIMARY KEY,
	NazevPredmetu VARCHAR(50) NOT NULL
);

CREATE TABLE Studenti(
	IDStudent INT NOT NULL PRIMARY KEY,
	Jmeno VARCHAR(25) NOT NULL,
	Prijmeni VARCHAR(25) NOT NULL,
	DatumNarozeni DATE NOT NULL
);

--3 + 4

CREATE TABLE ZapsanePredmety(
	IDStudent INT NOT NULL,
	Zkratka VARCHAR(10) NOT NULL,
	PRIMARY KEY (IDStudent, Zkratka),
	FOREIGN KEY (IDStudent) REFERENCES Studenti(IDStudent),
	FOREIGN KEY (Zkratka) REFERENCES Predmety(Zkratka)
);

--5
CREATE TABLE Hodnoceni(
	IDStudent INT NOT NULL,
	Zkratka VARCHAR(10) NOT NULL,
	DatumHodnoceni DATE NOT NULL,
	Hodnoceni INT NOT NULL,
	PRIMARY KEY (IDStudent, Zkratka),
	FOREIGN KEY (IDStudent) REFERENCES Studenti(IDStudent),
	FOREIGN KEY (Zkratka) REFERENCES Predmety(Zkratka)
);

--6
--predmety
INSERT INTO Predmety VALUES
	('BPC-IC2', 'Bezpecnost ICT 2'),
	('BPC-MDS', 'Multimedialni sluzby'),
	('BPC-SPR', 'Softwarove pravo'),
	('BPC-OOP', 'Objektove orientovane programovani'
);
--studenti
INSERT INTO Studenti VALUES
	(1, 'Jan', 'Novak', '2000-01-01'),
	(2, 'Petr', 'Novak', '1999-05-15'),
	(3, 'Eva', 'Kralova', '2001-09-30'),
	(4, 'Tomas', 'Dlouhy', '2000-12-12'
);

--zapsane predmety
INSERT INTO ZapsanePredmety VALUES
	(1, 'BPC-IC2'), (1, 'BPC-MDS'),
	(2, 'BPC-SPR'), (2, 'BPC-OOP'),
	(3, 'BPC-OOP'), (3, 'BPC-MDS'),
	(4, 'BPC-IC2'), (4, 'BPC-OOP');

--hodnoceni
INSERT INTO Hodnoceni VALUES
	(1, 'BPC-IC2', '2024-01-15', 1),
	(1, 'BPC-MDS', '2024-02-20', 2),
	(2, 'BPC-SPR', '2024-01-30', 3),
	(2, 'BPC-OOP', '2024-03-10', 4),
	(3, 'BPC-OOP', '2024-02-25', 1),
	(3, 'BPC-MDS', '2024-03-05', 2),
	(4, 'BPC-IC2', '2024-01-20', 3),
	(4, 'BPC-OOP', '2024-02-28', 4);

--8
SELECT s.Jmeno, s.Prijmeni, p.Zkratka,p.NazevPredmetu FROM Studenti s 
LEFT JOIN ZapsanePredmety zp ON s.IDStudent = zp.IDStudent
LEFT JOIN Predmety p ON zp.Zkratka = p.Zkratka;

--9
SELECT Prijmeni, COUNT(*) AS CNT FROM Studenti
GROUP BY Prijmeni 
HAVING COUNT(*) > 1 
ORDER BY CNT DESC;

--10
SELECT p.Zkratka, p.NazevPredmetu, COUNT(zp.IDStudent) AS PocetStudentu
FROM Predmety p
LEFT JOIN ZapsanePredmety zp ON p.Zkratka = zp.Zkratka
GROUP BY p.Zkratka, p.NazevPredmetu
HAVING COUNT(zp.IDStudent) < 3;

--11
SELECT p.Zkratka, p.NazevPredmetu,
MAX(h.Hodnoceni) AS NejlepsiHodnoceni,
MIN(h.Hodnoceni) AS NejhorsiHodnoceni,
AVG(CAST(h.Hodnoceni AS DECIMAL(10,2))) AS PrumerneHodnoceni,
COUNT(h.IDStudent) AS PocetHodnocenychStudentu
FROM Predmety p
LEFT JOIN Hodnoceni h ON p.Zkratka = h.Zkratka
GROUP BY p.Zkratka, p.NazevPredmetu;
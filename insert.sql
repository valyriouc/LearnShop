USE learnshop;

INSERT INTO addresses(street, houseNumber, zipCode, city) VALUES('musterstr', 20, 11111, 'musterstadt');

INSERT INTO persons(firstname, lastname, addressId) VALUES('max', 'mustermann', 1);

INSERT INTO paymentMethods(name, personId) VALUES('Paypal', 1);

INSERT INTO accounts(username, password, personId) VALUES('Valacor', '804f50ddbaab7f28c933a95c162d019acbf96afde56dba10e4c7dfcfe453dec4bacf5e78b1ddbdc1695a793bcb5d7d409425db4cc3370e71c4965e4ef992e8c4', 1);

INSERT INTO products(name, description, price, amount, personId) VALUES('test product', 'This is a test product', 600, 10, 1);
INSERT INTO products(name, description, price, amount, personId) VALUES('Kaffeemaschine', 'Eine hochwertige Kaffeemaschine mit eingebautem Mahlwerk.', 24900, 15, 1);
INSERT INTO products(name, description, price, amount, personId) VALUES('Smartphone', 'Ein leistungsstarkes Smartphone mit großem Display und schnellem Prozessor.', 79900, 30, 1);
INSERT INTO products(name, description, price, amount, personId) VALUES('Bluetooth-Lautsprecher', 'Kompakter Lautsprecher mit gutem Klang und drahtloser Verbindung.', 5900, 50, 1);
INSERT INTO products(name, description, price, amount, personId) VALUES('Fitness-Tracker', 'Ein Armband zur Überwachung von Aktivitäten Herzfrequenz und Schlafqualität.', 12900, 20, 1);
INSERT INTO products(name, description, price, amount, personId) VALUES('Externe Festplatte', '1 TB Speicherplatz für Backups und Dateispeicherung.', 7900, 10, 1);
INSERT INTO products(name, description, price, amount, personId) VALUES('Bürostuhl', 'Ergonomischer Stuhl mit verstellbarer Rückenlehne und Armlehnen.', 14900, 25, 1);
INSERT INTO products(name, description, price, amount, personId) VALUES('Digitalkamera', 'Kompakte Kamera mit hoher Auflösung und vielseitigen Aufnahmefunktionen.', 39900, 12, 1);
INSERT INTO products(name, description, price, amount, personId) VALUES('Powerbank', 'Tragbares Ladegerät für unterwegs mit 10.000 mAh Kapazität.', 2900, 40, 1);
INSERT INTO products(name, description, price, amount, personId) VALUES('Gaming-Maus', 'Präzise Maus mit anpassbaren Tasten und RGB-Beleuchtung.', 6900, 18, 1);
INSERT INTO products(name, description, price, amount, personId) VALUES('Wasserkocher', 'Schnellkochender Wasserkocher mit automatischer Abschaltung.', 3900, 22, 1);
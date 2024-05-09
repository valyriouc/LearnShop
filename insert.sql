USE learnshop;

INSERT INTO addresses(street, houseNumber, zipCode, city) VALUES('musterstr', 20, 11111, 'musterstadt');

INSERT INTO persons(firstname, lastname, addressId) VALUES('max', 'mustermann', 1);

INSERT INTO paymentMethods(name, personId) VALUES('Paypal', 1);

INSERT INTO accounts(username, password, personId) VALUES('Valacor', '804f50ddbaab7f28c933a95c162d019acbf96afde56dba10e4c7dfcfe453dec4bacf5e78b1ddbdc1695a793bcb5d7d409425db4cc3370e71c4965e4ef992e8c4', 1);

INSERT INTO products(name, description, imageUrl, amount, personId) VALUES('test product', 'This is a test product', 600, 10, 1);
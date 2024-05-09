DROP DATABASE IF EXISTS learnshop;
CREATE DATABASE IF NOT EXISTS learnshop;
USE learnshop;

CREATE TABLE addresses(
    addressId INT PRIMARY KEY AUTO_INCREMENT,
    street TEXT NOT NULL,
    houseNumber INT NOT NULL,
    zipCode INT NOT NULL,
    city TEXT NOT NULL
);

CREATE TABLE persons(
    personId INT PRIMARY KEY AUTO_INCREMENT,
    firstname VARCHAR(200) NOT NULL,
    lastname VARCHAR(200) NOT NULL,
    addressId INT REFERENCES addresses(addressId)
);

CREATE TABLE paymentMethods(
    pmId INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(100) NOT NULL,
    personId INT REFERENCES persons(personId)
);

CREATE TABLE accounts(
    accountId INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(200) NOT NULL UNIQUE,
    password TEXT NOT NULL,
    personId INT REFERENCES persons(personId)
);

CREATE TABLE products(
    productId INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(150) NOT NULL,
    description TEXT,
    imageUrl TEXT,
    price INT NOT NULL,
    amount INT NOT NULL,
    personId INT REFERENCES persons(personId)
);

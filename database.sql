DROP DATABASE IF EXISTS learnshop;
CREATE DATABASE IF NOT EXISTS learnshop;
USE learnshop;

CREATE TABLE addresses(
    addressId INT PRIMARY KEY AUTOINCREMENT,
    street TEXT NOT NULL,
    addressNumber INT NOT NULL,
    zipCode INT NOT NULL,
    city TEXT NOT NULL
);

CREATE TABLE persons(
    personId INT PRIMARY KEY AUTOINCREMENT,
    firstname VARCHAR(200) NOT NULL,
    lastname VARCHAR(200) NOT NULL,
    addressId INT REFERENCES addresses(addressId)
);

CREATE TABLE paymentMethods(
    pmId INT PRIMARY KEY AUTOINCREMENT,
    name VARCHAR(100) NOT NULL,
);

CREATE TABLE accounts(
    accountId INT PRIMARY KEY AUTOINCREMENT,
    username VARCHAR(200) NOT NULL UNIQUE,
    password TEXT NOT NULL,
    personId INT REFERENCES persons(personId),
);

CREATE TABLE products(
    productId INT PRIMARY KEY AUTOINCREMENT,
    name VARCHAR(150) NOT NULL,
    description TEXT,
    imageUrl TEXT NOT NULL,
    price INT NOT NULL,
    amout INT NOT NULL,
    personId INT REFERENCES persons(personId)
);

CREATE TABLE customer (
    id SERIAL PRIMARY KEY,
    surname VARCHAR(20),
    first_name VARCHAR(20),
    second_name VARCHAR(20),
    gender BOOLEAN,
    nationality VARCHAR(20),
    height NUMERIC,
    weight NUMERIC,
    birth_date DATE,
    phone_number VARCHAR(20),
    postcode INT,
    country VARCHAR(20),
    region VARCHAR(20),
    district VARCHAR(20),
    city VARCHAR(20),
    street VARCHAR(20),
    house INT,
    flat INT,
    credit_card_number VARCHAR(30),
    bank_account_number VARCHAR(30)
);

INSERT INTO customer (surname, first_name, second_name, gender, nationality, height, weight, birth_date, phone_number, postcode, country, region, district, city, street, house, flat, credit_card_number, bank_account_number)
VALUES ('Ivanov', 'Ivan', 'Ivanovich', true, 'Belarusian', 1.8, 79.5, '1990-4-21', '375291234567', 220076, 'Belarus', 'Minsky', 'Minsky', 'Minsk', 'Slobodskaya', 23, 117, 'byt23473hfw73', 32784872371),
       ('Petrov', 'Petr', 'Petrovich', true, 'Belarusian', 1.67, 65.3, '1987-8-1', '375447851287', 220076, 'Belarus', 'Brestsky', 'Brestsky', 'Brest', 'Pushkina', 15, 2, 'zdr69365ysl15', 12874981209),
       ('Ivanova', 'Anna', 'Ivanovna', false, 'Belarusian', 1.65, 89.1, '2003-12-6', '375298365509', 220076, 'Belarus', 'Minsky', 'Minsky', 'Minsk', 'Pobedy square', 7, 213, 'top63398orp16', 41409212945),
       ('Smirnov', 'Miron', 'Semenovich', true, 'Belarusian', 1.8, 89.22, '1997-1-13', '375338175098', 220076, 'Belarus', 'Gomelsky', 'Gomelsky', 'Gomel', 'Dzerzhinskogo', 4, null, 'iiu89017zzk22', 22973076899),
       ('Kotov', 'Vladimir', 'Igorevich', true, 'Belarusian', 1.89, 100.3, '1995-5-8', '375292340987', 220076, 'Belarus', 'Minsky', 'Soligorsky', 'Soligorsk', 'Lenina', 81, 55, 'wer46709odk92', 16329993456),
       ('Petrova', 'Maria', 'Mihailovna', false, 'Belarusian', 1.65, 59.0, '2000-10-17', '375445679876', 220076, 'Belarus', 'Brestsky', 'Brestsky', 'Breat', 'Volodarskogo', 17, 64, 'byi32784lao63', 27382991203),
       ('Smirnova', 'Svetlana', 'Stepanovna', false, 'Belarusian', 1.71, 71.3, '1984-4-14', '375291718190', 220076, 'Belarus', 'Brestsky', 'Brestsky', 'Brest', 'Morozova', 22, 87, 'off11874oqi81', 34729502493);

SELECT *
FROM customer
WHERE city = 'Brest';

CREATE TABLE shop (
    id SERIAL PRIMARY KEY,
    shop_name VARCHAR(30),
    shop_description VARCHAR(225)
);

INSERT INTO shop (shop_name, shop_description)
VALUES ('SHOP1', 'GOOD SHOP'),
       ('SHOP2', 'NOT SO GOOD SHOP'),
       ('SHOP3', 'VERY BAD SHOP'),
       ('SHOP4', 'VERY GOOD SHOP'),
       ('SHOP5', 'BAD SHOP'),
       ('SHOP6', 'NOT SO BAD SHOP'),
       ('SHOP7', 'AWESOME SHOP');

ALTER TABLE customer
    ADD COLUMN shop_id INT REFERENCES shop (id),
    ADD COLUMN email VARCHAR(30);

UPDATE customer
SET shop_id = house % 7 + 1,
    email = surname || '@gmail.com';


SELECT customer.id, surname, first_name, phone_number, credit_card_number, shop_name
FROM customer JOIN shop ON customer.shop_id = shop.id;

SELECT count(*)
FROM customer
WHERE height = 1.65;

SELECT sum(weight)
FROM customer
WHERE gender = true;

SELECT min(weight), max(weight)
FROM customer;

SELECT *
FROM customer INNER JOIN shop ON customer.shop_id = shop.id
WHERE shop.id IN (2, 4);

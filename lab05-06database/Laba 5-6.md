**лаба 5.**

**Шаг 1:**

SELECT current\_database() AS database\_name,

&#x20;      current\_user AS user\_name,

&#x20;      version() AS server\_version;

**Шаг 3:**

BEGIN;



CREATE TEMP TABLE parent\_demo (

&#x20;   id integer PRIMARY KEY

);



CREATE TEMP TABLE child\_demo (

&#x20;   id integer PRIMARY KEY,

&#x20;   parent\_id integer NOT NULL,

&#x20;   CONSTRAINT fk\_demo\_restrict

&#x20;       FOREIGN KEY (parent\_id) REFERENCES parent\_demo(id)

&#x20;       ON DELETE RESTRICT

);



INSERT INTO parent\_demo VALUES (1);

INSERT INTO child\_demo VALUES (10, 1);



SELECT \* FROM parent\_demo;

SELECT \* FROM child\_demo;



DELETE FROM parent\_demo WHERE id = 1;



ROLLBACK;

**Шаг 4:**

BEGIN;



CREATE TEMP TABLE parent\_demo (

&#x20;   id integer PRIMARY KEY

);



CREATE TEMP TABLE child\_demo (

&#x20;   id integer PRIMARY KEY,

&#x20;   parent\_id integer NOT NULL,

&#x20;   CONSTRAINT fk\_demo\_cascade

&#x20;       FOREIGN KEY (parent\_id) REFERENCES parent\_demo(id)

&#x20;       ON DELETE CASCADE

);



INSERT INTO parent\_demo VALUES (1), (2);

INSERT INTO child\_demo VALUES (10, 1), (11, 1), (20, 2);



SELECT \* FROM parent\_demo ORDER BY id;

SELECT \* FROM child\_demo ORDER BY id;



DELETE FROM parent\_demo WHERE id = 1;



SELECT \* FROM parent\_demo ORDER BY id;

SELECT \* FROM child\_demo ORDER BY id;



DELETE FROM child\_demo WHERE id = 20;



SELECT \* FROM parent\_demo ORDER BY id;

SELECT COUNT(\*) AS children\_left FROM child\_demo;



ROLLBACK;

**Шаг 5:**

BEGIN;



CREATE TEMP TABLE parent\_demo (

&#x20;   id integer PRIMARY KEY

);



CREATE TEMP TABLE child\_demo (

&#x20;   id integer PRIMARY KEY,

&#x20;   parent\_id integer, -- БЕЗ NOT NULL, иначе SET NULL не сработает

&#x20;   CONSTRAINT fk\_demo\_set\_null

&#x20;       FOREIGN KEY (parent\_id) REFERENCES parent\_demo(id)

&#x20;       ON DELETE SET NULL

);



INSERT INTO parent\_demo VALUES (1), (2);

INSERT INTO child\_demo VALUES (10, 1), (11, 1), (20, 2);



DELETE FROM parent\_demo WHERE id = 1;



SELECT \* FROM parent\_demo ORDER BY id;

SELECT \* FROM child\_demo ORDER BY id;



SELECT COUNT(\*) AS empty\_references

FROM child\_demo WHERE parent\_id IS NULL;



ROLLBACK;

**Шаг 6:**

BEGIN;



CREATE TEMP TABLE parent\_demo (

&#x20;   id integer PRIMARY KEY

);



CREATE TEMP TABLE child\_demo (

&#x20;   id integer PRIMARY KEY,

&#x20;   parent\_id integer NOT NULL, -- Есть NOT NULL

&#x20;   CONSTRAINT fk\_demo\_set\_null\_required

&#x20;       FOREIGN KEY (parent\_id) REFERENCES parent\_demo(id)

&#x20;       ON DELETE SET NULL

);



INSERT INTO parent\_demo VALUES (1);

INSERT INTO child\_demo VALUES (10, 1);



DELETE FROM parent\_demo WHERE id = 1;



ROLLBACK;

**Шаг 7:**

BEGIN;



CREATE TEMP TABLE room\_pair\_demo (

&#x20;   building\_id integer NOT NULL,

&#x20;   room\_no integer NOT NULL,

&#x20;   CONSTRAINT pk\_room\_pair\_demo PRIMARY KEY (building\_id, room\_no)

);



CREATE TEMP TABLE booking\_pair\_demo (

&#x20;   booking\_id integer PRIMARY KEY,

&#x20;   building\_id integer NOT NULL,

&#x20;   room\_no integer NOT NULL,

&#x20;   CONSTRAINT fk\_booking\_room\_pair

&#x20;       FOREIGN KEY (building\_id, room\_no)

&#x20;       REFERENCES room\_pair\_demo(building\_id, room\_no)

&#x20;       ON DELETE RESTRICT

);



INSERT INTO room\_pair\_demo VALUES (1, 101), (2, 202);

ы

INSERT INTO booking\_pair\_demo VALUES (1001, 1, 101), (1002, 2, 202);

SELECT \* FROM booking\_pair\_demo ORDER BY booking\_id;



INSERT INTO booking\_pair\_demo VALUES (1003, 1, 202);



ROLLBACK;

**лаба 6.**

**Шаг 1:**

SELECT current\_database() AS database\_name, current\_user AS user\_name;

SELECT 'customer' AS table\_name, COUNT(\*) AS row\_count FROM customer

UNION ALL

SELECT 'sender', COUNT(\*) FROM sender

UNION ALL

SELECT 'courier', COUNT(\*) FROM courier

UNION ALL

SELECT 'departure', COUNT(\*) FROM departure

UNION ALL

SELECT 'cargoplace', COUNT(\*) FROM cargoplace

UNION ALL

SELECT 'route', COUNT(\*) FROM route

UNION ALL

SELECT 'stop', COUNT(\*) FROM stop

UNION ALL

SELECT 'deliveryattempt', COUNT(\*) FROM deliveryattempt

ORDER BY table\_name;

**Шаг 2:**

SELECT conrelid::regclass AS table\_name,

&#x20;      conname AS constraint\_name,

&#x20;      pg\_get\_constraintdef(oid) AS definition

FROM pg\_constraint

WHERE connamespace = 'public'::regnamespace

ORDER BY conrelid::regclass::text, conname;

**Шаг 3:**

BEGIN;



INSERT INTO customer (surname, name, middlename, phone, email, address)

VALUES ('Тестов', 'Лев', 'Анатольевич', '+7(989)-317-02-18', 'test@mail.ru', 'г. Москва, ул. Тверская, 6');



SELECT id, surname, name FROM customer ORDER BY id;



ROLLBACK;

**Шаг 4:**

BEGIN;



INSERT INTO customer (id, surname, name, phone, address)

VALUES (1, 'Крид', 'Егор', '+7(800)-555-35-35', 'г. Москва');



ROLLBACK;

**Шаг 5:**

BEGIN;



INSERT INTO cargoplace (departureid, placenumber, weight, dimension)

VALUES (2, 1, 99.0, '99x99x99');



ROLLBACK;

**Шаг 6:**

BEGIN;



INSERT INTO customer (surname, name, phone, address)

VALUES (NULL, 'Иван', '+7(000)-000-00-00', 'г. Москва');



ROLLBACK;

**Шаг 7:**

BEGIN;



INSERT INTO cargoplace (departureid, placenumber, weight, dimension)

VALUES (1, 2, -5, '10x10x10');



ROLLBACK;

**Шаг 8:**

BEGIN;



INSERT INTO stop (routeid, address, plannedtime, sequencenumber)

VALUES (1, 'г. Москва', '2026-10-14 10:00', -1);



ROLLBACK;

**Шаг 9:**

BEGIN;



INSERT INTO deliveryattempt (departureid, stopid, attemptdate, attempttime, result)

VALUES (999, 1, '2026-10-14', '10:00', 'неудача');



ROLLBACK;

**Шаг 10:**

BEGIN;



DELETE FROM customer WHERE id = 1;



ROLLBACK;










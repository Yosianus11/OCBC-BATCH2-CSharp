CREATE TABLE CUSTOMERS(
CUSTOMER_NUMBER VARCHAR(10) NOT NULL PRIMARY KEY,
CUSTOMER_NAME VARCHAR(50) NULL,
CONTACT_LAST_NAME VARCHAR(25) NULL,
CONTACT_FIRST_NAME VARCHAR(25) NULL,
ADDRESS_LINE1 VARCHAR(50) NULL,
ADDRESS_LINE2 VARCHAR(50) NULL,
CITY VARCHAR(50) NULL,
[STATE] VARCHAR(50) NULL,
POSTAL_CODE VARCHAR(10) NULL,
COUNTRY VARCHAR(20) NULL,
SALES_REP_EMPLOYEE_NUMBER VARCHAR(10) NULL,
CREDIT_LIMIT INT NULL
);

CREATE TABLE PRODUCTS_MBL(
PRODUCT_CODE VARCHAR(10) NOT NULL PRIMARY KEY,
PRODUCT_NAME VARCHAR(50) NULL,
PRODUCT_LINE VARCHAR(10) NULL,
PRODUCT_SCALE VARCHAR(20) NULL,
PRODUCT_VENDOR VARCHAR(50) NULL,
PRODUCT_DESCRIPTION TEXT NULL,
QUANTITY_IN_STOCK VARCHAR(50) NULL,
BUY_PRICE INT NULL,
MSRP INT NULL
);



CREATE TABLE PRODUCTS_LINES(
PRODUCT_LINE VARCHAR(10) NOT NULL PRIMARY KEY,
TEXT_DESCRIPTION TEXT NULL,
HTML_DESCRIPTION VARCHAR(10) NULL,
[IMAGE] VARCHAR(200) NULL
);







CREATE TABLE ORDERS(
ORDER_NUMBER VARCHAR(10) NOT NULL PRIMARY KEY,
ORDER_DATE DATE NULL,
REQUIRED_DATE DATE NULL,
SHIPPED_DATE DATE NULL,
[STATUS] VARCHAR(10) NULL,
[COMMETS] TEXT NULL,
[COSTUMER_NUMBER] VARCHAR(10) NULL
);



CREATE TABLE ORDER_DETAILS(
ORDER_NUMBER VARCHAR(10) NULL ,
PRODUCT_CODE VARCHAR(10) NULL ,
QUANTITY_ORDERED INT NULL,
PRICE_EACH INT NULL,
ORDER_LINE_NUMBER VARCHAR(10) NULL
);





CREATE TABLE PAYMENTS(
CUSTOMER_NUMBER VARCHAR(10) NULL,
CHECK_NUMBER VARCHAR(10) NOT NULL PRIMARY KEY,
PAYMENTDATE DATE NULL,
AMOUNT INT NULL
);




CREATE TABLE EMPLOYEES(
EMPLOYEE_NUMBER VARCHAR(10) NOT NULL PRIMARY KEY,
LAST_NAME VARCHAR(25) NULL,
FIRST_NAME VARCHAR(25) NULL,
EXTENSION VARCHAR(10) NULL,
EMAIL VARCHAR(50) NULL,
OFFICE_CODE VARCHAR(10) NULL,
REPORTS_TO VARCHAR(50) NULL,
JOB_TITLE VARCHAR(50) NULL
);




CREATE TABLE OFFICES(
OFFICE_CODE VARCHAR(10) NOT NULL PRIMARY KEY,
CITY VARCHAR(50) NULL,
PHONE VARCHAR(15) NULL,
ADDERESS_LINE1 VARCHAR(25) NULL,
ADDERESS_LINE2 VARCHAR(25) NULL,
[STATE] VARCHAR(25) NULL,
COUNTRY VARCHAR(25) NULL,
POSTAL_CODE VARCHAR(10) NULL,
TERRITORY VARCHAR(25) NULL
);
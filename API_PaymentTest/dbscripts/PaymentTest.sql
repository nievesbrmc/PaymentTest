create database PaymenTest

use PaymenTest

create table PaymentStatus(
PaymentStatusId bigint identity(1,1) primary key,
PaymentStatusDescription varchar(100))

insert into PaymentStatus values ('Aplicado')
insert into PaymentStatus values ('Rechazado')

create table PaymentsLog(
PaymentId bigint identity(1,1) primary key,
PaymentConcept varchar(100),
ProuctQuantity int,
Paymentfrom varchar(100),
PaymentTo  varchar(100),
Amount decimal,
PaymentStatusId bigint,
FOREIGN KEY (PaymentStatusId) REFERENCES PaymentStatus(PaymentStatusId))
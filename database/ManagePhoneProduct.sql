create database ManagePhoneProduct;

create table accLogin(
	username varchar(20),
	password varchar(30)
);


insert into accLogin values ('thinhisme','123456');
select * from accLogin

create table productInfor(
	idProduct varchar(20) PRIMARY KEY,
	productName varchar(30),
	quantity int,
	price int
);
create table temptProductInfor (
	idsProduct varchar(20)
);
select * from temptProductInfor
--delete from productInfor
create table manageProductImport(
	idProduct varchar(20),
	productName varchar(30),
	quantitySold int,
	availabelQuantity int,
	price int,
	FOREIGN KEY (idProduct) REFERENCES productInfor(idProduct)
);

--select * from detailReceipt
create table manageProductExport(
	idProduct varchar(20),
	productName varchar(30),
	quantitySold int,
	price int
	FOREIGN KEY (idProduct) REFERENCES productInfor(idProduct)
);
--select * from manageProductExport

--receipt import
create table detailReceipt(
	idReceipt varchar(10) NOT NULL PRIMARY KEY,
	idAccountant varchar(10),
	creationData date,
	totalPrice int,
	goods varchar(100)
);
select * from detailReceipt
--delivery bill
create table deliveryBill (
	id varchar(10),
	idAccountant varchar(10),
	disID varchar(10),
	disName varchar(20),
	pmMethod varchar(20),
	pmStatus varchar(20),
	orStatus varchar(20),
	idProduct varchar(20),
	quantity int,
	createDate date
	FOREIGN KEY (idProduct) REFERENCES productInfor(idProduct)
);
--delete from productInfor
create table revenueMonth( 
	time date,
	revenueMonthly int
);
--delete from deliveryBill
--select * from productInfor
--delete from manageProductExport where idProduct = 'pro05'



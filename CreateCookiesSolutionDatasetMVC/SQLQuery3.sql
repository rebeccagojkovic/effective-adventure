CREATE TABLE Supplier(
sNumber int not null,
sLocation varchar(15),
CONSTRAINT Supplier_PK primary key (sNumber),
)

CREATE TABLE Ingridient(
iNumber int not null,
iName varchar(15),
iquantityInStock int,
CONSTRAINT Ingredient_PK primary key (iNumber),
CONSTRAINT sNumber_FK FOREIGN KEY(sNumber)REFERENCES Supplier(sNumber) 
)

CREATE TABLE Product(
pNumber int not null,
pName varchar(15),
pTime datetime,
CONSTRAINT Product_PK primary key (pNumber),
)
CREATE TABLE Recipe(
pNumber int not null,
iNumber int not  null,
CONSTRAINT Pecipe_PK primary key (pNumber, iNumber),
CONSTRAINT pNumber_FK FOREIGN KEY(pNumber)REFERENCES Product(pNumber),
CONSTRAINT iNumber_FK FOREIGN KEY(iNumber)REFERENCES Ingridient(iNumber),
)
CREATE TABLE Customer(
cNumber int not null,
cName varchar(15),
cAddress varchar(30),
CONSTRAINT Customer_PK primary key (cNumber)
)

CREATE TABLE Orde(
oNumber int not null,
isDelivered bit,
expectedDeliveryDate datetime not null,
CONSTRAINT Order_PK primary key (oNumber),
CONSTRAINT cNumber_FK FOREIGN KEY(cNumber) REFERENCES Customer(cNumber)
)
CREATE TABLE Pallet(
palletNumber int not null,
palletTime datetime not  null,
CONSTRAINT Pallet_PK primary key (palletNumber),
CONSTRAINT pNumber_FK FOREIGN KEY(pNumber)REFERENCES Product(pNumber),
CONSTRAINT oNumber_FK FOREIGN KEY(oNumber)REFERENCES Orde(oNumber),
)
CREATE TABLE Orderspecfikation(
oNumber int not null,
pNumber int not  null,
CONSTRAINT OrderSpecification_PK primary key (pNumber, oNumber),
CONSTRAINT pNumber_FK FOREIGN KEY(pNumber)REFERENCES Product(pNumber),
CONSTRAINT oNumber_FK FOREIGN KEY(oNumber)REFERENCES Orde(oNumber),
)

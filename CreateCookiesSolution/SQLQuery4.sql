Insert into Customer(cNumber,cAddress, cCountry,cEmail,cName,cPostalAddress) values('1','Nygatan','Sweden','ake@bageriet.se','Bageriet','Malmö');
Insert into Customer(cNumber,cAddress, cCountry,cEmail,cName,cPostalAddress) values('2','Östergatan','Sweden','anna@Ambrossia.se','Ambrossia','Lund');
Insert into Customer(cNumber,cAddress, cCountry,cEmail,cName,cPostalAddress) values('3','Hallongränd','Sweden','per@espressphouse.se','Espresso House','Svedala');
Insert into Customer(cNumber,cAddress, cCountry,cEmail,cName,cPostalAddress) values('4','Pärongränd','Sweden','ake@Hollandia.se','Hollandia','Norrköping');
Insert into Customer (cNumber,cAddress, cCountry,cEmail,cName,cPostalAddress)values('5','Olle römmers väg','Sweden','Ture@bageriet.se','Bageriet','Lund');
Insert into Customer(cNumber,cAddress, cCountry,cEmail,cName,cPostalAddress) values('6','Studentgatan','Sweden','ake@GyllinsKonditori.se','Gyllins Konditori','Trelleborg');

Insert into Ingredient(iNumber,iName,iQuantityInStock) values('1','Smör','10000');
Insert into Ingredient(iNumber,iName,iQuantityInStock) values('2','Mjöl','10000');
Insert into Ingredient(iNumber,iName,iQuantityInStock) values('3','Socker','10000');
Insert into Ingredient(iNumber,iName,iQuantityInStock) values('4','Ägg','1000');
Insert into Ingredient(iNumber,iName,iQuantityInStock)values('5','Nötter','10000');
Insert into Ingredient(iNumber,iName,iQuantityInStock) values('6','Marsipan','10000');
Insert into Ingredient(iNumber,iName,iQuantityInStock) values('7','Mjölk','10000');
Insert into Ingredient(iNumber,iName,iQuantityInStock) values('8','Mandel','10000');
Insert into Ingredient(iNumber,iName,iQuantityInStock) values('9','vaniljsocker','1000');
Insert into Ingredient(iNumber,iName,iQuantityInStock) values('10','Choklad','10000');

Insert into Orde(oNumber,isDelivered,expectedDeliveryDate) values('1','false',2016-12-12);
Insert into Orde(oNumber,isDelivered,expectedDeliveryDate) values('2','true',2016-12-12);
Insert into Orde(oNumber,isDelivered,expectedDeliveryDate) values('3','true',2016-12-12);
Insert into Orde(oNumber,isDelivered,expectedDeliveryDate) values('4','false',2016-12-12);
Insert into Orde(oNumber,isDelivered,expectedDeliveryDate) values('5','false',2016-12-12);
Insert into Orde(oNumber,isDelivered,expectedDeliveryDate) values('6','false',2016-12-12);

Insert into Orderspecification(oNumber,pNumber,palletQuantity) values('1','1',10);
Insert into Orderspecification(oNumber,pNumber,palletQuantity) values('1','2',5);
Insert into Orderspecification(oNumber,pNumber,palletQuantity) values('2','3',2);
Insert into Orderspecification(oNumber,pNumber,palletQuantity) values('3','1',1);
Insert into Orderspecification(oNumber,pNumber,palletQuantity) values('4','1',4);
Insert into Orderspecification(oNumber,pNumber,palletQuantity) values('5','3',5);

Insert into Product(pNumber,pName,pTime,price) values('1','kokostoppar','11:20:24',10);
Insert into Product(pNumber,pName,pTime,price) values('2','Nötingar','13:20:24',15);
Insert into Product(pNumber,pName,pTime,price) values('3','Nötkakor','12:20:24',20);
Insert into Product(pNumber,pName,pTime,price) values('4','Amneris','16:20:24',15);
Insert into Product(pNumber,pName,pTime,price) values('5','Tango','15:20:24',10);
Insert into Product(pNumber,pName,pTime,price) values('6','Berliner','17:20:24',15);

Insert into Recipe(iNumber,pNumber,Quantity) values('1','2',450);
Insert into Recipe(iNumber,pNumber,Quantity) values('2','2',450);
Insert into Recipe(iNumber,pNumber,Quantity) values('3','2',190);
Insert into Recipe(iNumber,pNumber,Quantity) values('5','2',225);
Insert into Recipe(iNumber,pNumber,Quantity) values('5','3',1375);
Insert into Recipe(iNumber,pNumber,Quantity) values('3','3',375);
Insert into Recipe(iNumber,pNumber,Quantity) values('4','3',4);
Insert into Recipe(iNumber,pNumber,Quantity) values('3','3',50);


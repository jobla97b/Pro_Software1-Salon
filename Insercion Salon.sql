Use Salon 

--------Insercion de Datos en tabla Clientes---------------------------------------------------------------------------
Insert into Cliente values
('0010409950039L','Jean','Carlos','Ruiz','Chamorro','89593785','jrch0495@gmail.com','Colonia Unidad de Proposito',1),
('0010404680023B','Sara','Maria','Centeno',null,'22632715','sarchte@gmail.com','Managua, Managua',1),
('0041502970008C','Carlos','Francisco','Telmas','Critensen','89067323','cftelmas@gmail.com','Colonia 1ro. de mayo',1),
('0080804581053S','Gabriela',null,'Chavarria','Alvarado','85672890','bAI09@gmail.com','Bro. Km8',1),
('0090409950039L','Maria','Angeles','Rivera','Lozano',null,'Lozano@gmail.com','Reparto San Juan',1),
('0030912950089J','Stephany','Rosario','Mendoza',null,'54678292','Rosmend@gmail.com','Carretera a masaya',1),
('0130409920005Z','Laiz','Clara','Largaespada','Cliford','89034576',null,'Colonia Salvadorita',1),
('0020409820021N','Nadiuska','Melani','Helfensthein','Lozano','22456378',null,'Rotonda La virgen 1C abajo',1)
------------------------------------------------------------------------------------------------------------------------

---------------------Insercion de Cargos-----------------------------------------------------------------------------
Insert into Cargo values
('Gerente',1),
('Supervisor',1),
('Recepcionista',1),
('Estilista',1),
('mortal',1),
('Almacenador',1)
---------------------------------------------------------------------------------------------------------------------

--------------------Insercion de Empleados---------------------------------------------------------------------------
Insert into Empleado values
  0810908960000J   joseph         blanco   blanco        josep@gmail.com      vistas      1 1
('0021106900004K','Maritza',null,'Blanco','Blanco',null,'blancoer@gmail.com','Los Robles',1,1),
('0021307901234T','Mario','Alberto','Castillo',null,'89002300','marioalber@gmail.com','Bro. Las Torres',2,1),
('0091001800000W','Leonardo',null,'Vega','Estrada','22400592','leovega@gmail.com','Bro. Lomalinda',2,1),
('0082308870008P','Ezequiel','Eusebio','Rapaccioli','Balmaceda','22400593','ee1987@yahoo.com','Montoya',3,1),
('0100205970015D','Marlon','Joel','Castillo','Sarria','23400592','marlonc@gmail.com','Bro. Laureles Norte',4,1),
('0311703873376A','Cristel','Esperanza','Dario','Gomez','88765432','cristel18@gmail.com','Reparto San Juan',4,1)
---------------------------------------------------------------------------------------------------------------------


----------------------Insercion de Ususarios-------------------------------------------------------------------------
Insert into Users values
(1,'marit01','mariajuanita07'),
(2,'marialb02','marialberto07'),
(3,'vegaestrada3','gatitobonito09'),
(4,'Rappacioli04','tevaleverga15'),
(5,'Marlojoe','morenito69'),
(6,'cris06','qwerty12345')
---------------------------------------------------------------------------------------------------------------------

---------------------Insercion Categorias de Servicios---------------------------------------------------------------
Insert into Categoria_servicio values
('Cortes','C',null,1),
('Tintes','C',null,1),
('Secado','C',null,1),
('Iluminaciones','C',null,1),
('Keratina','D',32.18,1),
('Chocolita','C',null,1),
('Chocolita1','D',32.18,1)
--------------------------------------------------------------------------------------------------------------------

-------------------Insercion de Servicios------------------------------------------------------------------------------
Insert into Servicios values
(1,'Corte de Dama','00:50:00',400,1),
(1,'Corte de Caballero','00:35:00',200,1),
(1,'Corte de ni�a','00:45:00',150,1),
(1,'Corte de ni�o','00:45:00',150,1),
-------------------------------------------
(2,'Tintes Cabellos Cortos','01:45:00',800,1),
(2,'Tintes Cabellos medianos','01:45:00',900,1),
(2,'Tintes Cabellos Largos','01:45:00',1000,1),
-------------------------------------------
(3,'Secado Cabellos Cortos','00:20:00',350,1),
(3,'Secado Cabellos Largo','00:30:00',400,1),
-------------------------------------------
(4,'Ilumin. Cab. Cortos','02:00:00',1200,1),
(4,'Ilumin. Cab. Mediano','02:00:00',1200,1),
(4,'Ilumin. Cab. largo','02:00:00',1200,1),
-------------------------------------------
(5,'Keratina Cabello Mediano','02:00:00',75,1),
(5,'Keratina Cabello Largo','02:00:00',100,1),
-------------------------------------------
(6,'Chocolita 001','02:00:00',1290,1),
(6,'Chocolita 022','02:00:00',1900,1),
---------------------------------------------
(7,'Chocolita22 001','02:00:00',1290,1),
(7,'Chocolita22 022','02:00:00',1200,1)
------------------------------------------------------------------------------------------------------------------------

-----------------------------Insercion de Citas--------------------------------------------------------------------------
Insert into Cita values
(7,'01/07/18','10:00','12:35','C'),
(2,'01/07/18','13:00','14:15','F'),
(4,'14/09/18','14:00','18:15','C'),
(2,'21/09/18','11:00','12:15','F'),
(3,'01/08/18','15:00','15:35','F'),
(1,'17/08/18','09:30','10:05','F'),
(1,'11/11/18','09:00','9:35','F'),
(5,'01/12/18','13:00','15:00','C'),
-------------------------------------------------------------------------------------------------------------------------

-----------------------------Insercion de Detalle Citas---------------------------------------------------------
Insert into Detalle_Cita values
(1,1,6,400),
(1,5,6,800),
(2,4,5,150),
(2,9,5,400),
(3,7,5,1000),
(3,9,5,400),
(3,16,5,1900),---editado
(4,4,6,150),
(4,9,6,400),
(5,2,5,200),
(6,2,5,200),
(7,2,6,200),
(8,14,5,100)

------------------------------------------Insercion de Facturas------------------------------------------------------------------------------
Insert into Factura values
--(2,4,'01-07-2018',82.5,550,1),--T.Credito
--(3,4,'14-09-2018',150,40016,1),--T.Credito,Efectivo C y D
--(4,2,'21-09-2018',0,550,1),---Efectivo C y Dolar
--(6,3,'17-08-18',0,200,1),--Efectivo C
--(7,4,'11-11-2018',24.75,200,1),--TarjetaC Y Efectivo C
(8,2,'01-12-18',248.625,3315,1)--TarjetaC y Efectivo D
---------------------------------------------------------------------------------------------------------------------------------------------

-----------------------------------------Insercion de Pagos----------------------------------------------------------------------------------
Insert into Modo_Pago values
--(1,'C','C',632.5,0,0),--1 solo pago
--(2,'C','C',1150,0,0),---3 Pagos 
--(2,'E','C',19708,20000,0),
--(2,'E','D',600,600,32.18),
--(3,'E','D',10,20,32.20),--2 Pagos 
--(3,'E','C',228,250,0),
--(4,'E','C',200,200,0)--1Pago unico
--(5,'C','C',189.75,0,0),--2 Pagos
--(5,'E','C',35,50,0),
(6,'C','C',1906.125,0,0),--2 Pagos
(6,'E','D',1657.5,50,33.15)




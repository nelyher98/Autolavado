DROP DATABASE Autolavado;
CREATE DATABASE Autolavado;
USE Autolavado;

CREATE TABLE Encargado(
 usuario       VARCHAR(10) NOT NULL PRIMARY KEY,
 contraseña    VARCHAR(10),
 Nombre        VARCHAR(45),
 Apellidos     VARCHAR(45)
);

CREATE TABLE Empleado(
 id_empleado   INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
 nombre        VARCHAR(20),
 apellidos     VARCHAR(150)
);

CREATE TABLE Carro(
 placa         VARCHAR(7) NOT NULL,
 tipo          ENUM('Chico','Mediano','Grande'),
 nombre        VARCHAR(45),
 apellidos     VARCHAR(45),
 fecha_N       DATE,
 PRIMARY KEY(placa)
);

CREATE TABLE Ticket(
 id_Ticket     INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
 placa_i       VARCHAR(7),
 emple_no      VARCHAR(20),
 tipo          SET('Lavado_Motor','Pulido','Encerado','Lavado_Normal'),
 total         FLOAT(5,2),
 fecha_t       DATE,
 INDEX(placa_i),
 FOREIGN KEY(placa_i) REFERENCES Carro(placa));

CREATE TABLE Producto(
 idProducto    INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
 nombre        VARCHAR(100),
 cantidad      INT,
 precio        FLOAT(5,2),
 fecha_t       DATE);

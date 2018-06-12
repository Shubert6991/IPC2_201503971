CREATE SCHEMA `BDIPC2` DEFAULT CHARACTER SET utf8 ;
USE `BDIPC2` ;

CREATE TABLE `BDIPC2`.`Administrador (Ninty)` (
  `ID.AdminN` INT NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `Apellido` VARCHAR(45) NULL,
  `Correo` VARCHAR(60) NOT NULL,
  PRIMARY KEY (`ID.AdminN`),
)

CREATE TABLE  `BDIPC2`.`Adminstrador (cliente)` (
  `ID.AdminC` INT NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `Apellido` VARCHAR(45) NULL,
  `Correo` VARCHAR(60) NOT NULL,
  `Tarjeta` INT NOT NULL,
  `ID.AdminN` INT NOT NULL,
  PRIMARY KEY (`ID.AdminC`),
    FOREIGN KEY (`ID.AdminN`)
)

CREATE TABLE `BDIPC2`.`Usuario` (
  `ID.Usuario` INT NOT NULL,
  `nombre` VARCHAR(45) NOT NULL,
  `apellido` VARCHAR(45) NULL,
  `ID.AdminC` INT NOT NULL,
  PRIMARY KEY (`ID.Usuario`),
    FOREIGN KEY (`ID.AdminC`)
)

CREATE TABLE `BDIPC2`.`Modulo` (
  `ID.Modulo` INT NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `Precio` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`ID.Modulo`),
)

CREATE TABLE `BDIPC2`.`Modulo adquirido` (
  `ID.Usuario` INT NOT NULL,
  `ID.AdminC` INT NOT NULL,
  `ID.Modulo` INT NOT NULL,
  `Estado` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`ID.Usuario`, `ID.AdminC`,`ID.Modulo`),
    FOREIGN KEY (`ID.Usuario` , `ID.AdminC`,`ID.Modulo`)
)

CREATE TABLE `BDIPC2`.`Inventario` (
  `idInventario` INT NOT NULL,
  `nombre` VARCHAR(45) NULL,
  `descripcion` VARCHAR(45) NULL,
  PRIMARY KEY (`idInventario`),
)

CREATE TABLE `BDIPC2`.`Producto` (
  `idProducto` INT NOT NULL,
  `nombre` VARCHAR(45) NULL,
  `descripcion` VARCHAR(45) NULL,
  `Precio` DOUBLE NULL,
  `idInventario` INT NOT NULL,
  PRIMARY KEY (`idProducto`),
    FOREIGN KEY (`idInventario`)
)

CREATE TABLE `BDIPC2`.`Cliente` (
  `idCliente` INT NOT NULL,
  `nombre` VARCHAR(45) NULL,
  `apellido` VARCHAR(45) NULL,
  `NIT` VARCHAR(45) NULL,
  PRIMARY KEY (`idCliente`),
)

CREATE TABLE `BDIPC2`.`Horario` (
  `idHorario` INT NOT NULL,
  `horas` INT NOT NULL,
  `no.dias` INT NOT NULL,
  PRIMARY KEY (`idHorario`),
)

CREATE TABLE `BDIPC2`.`Empleado` (
  `CUI` INT NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `Apellido` VARCHAR(45) NOT NULL,
  `Telefono` VARCHAR(45) NULL,
  `Horario_idHorario` INT NOT NULL,
  PRIMARY KEY (`CUI`),
    FOREIGN KEY (`idHorario`)
)

CREATE TABLE `BDIPC2`.`Vendedor` (
  `idVendedor` INT NOT NULL,
  `CUI` INT NOT NULL,
  PRIMARY KEY (`idVendedor`),
    FOREIGN KEY (`CUI`)
)

CREATE TABLE `BDIPC2`.`Venta` (
  `idVenta` INT NOT NULL,
  `Fecha` DATE NOT NULL,
  `Hora` TIME NOT NULL,
  `Monto` DOUBLE NOT NULL,
  `idCliente` INT NOT NULL,
  `idVendedor` INT NOT NULL,
  `idProducto` INT NOT NULL,
  PRIMARY KEY (`idVenta`),
    FOREIGN KEY (`idCliente`,`idProducto`,`idVendedor`)
)

CREATE TABLE `BDIPC2`.`Proveedor` (
  `idProveedor` INT NOT NULL,
  `nombre` VARCHAR(45) NULL,
  `correo` VARCHAR(45) NULL,
  `telefono` INT NULL,
  PRIMARY KEY (`idProveedor`),
)

CREATE TABLE `BDIPC2`.`Compra` (
  `idCompra` INT NOT NULL,
  `Monto` DOUBLE NOT NULL,
  `Fecha` DATE NOT NULL,
  `Hora` TIME NOT NULL,
  `idProveedor` INT NOT NULL,
  `idProducto` INT NOT NULL,
  PRIMARY KEY (`idCompra`),
    FOREIGN KEY (`idProveedor`,`idProducto` , `idInventario`)
)

CREATE TABLE `BDIPC2`.`Entrevista` (
  `idEntrevista` INT NOT NULL,
  `fecha` DATE NULL,
  `hora` TIME NULL,
  `nombreEntrevistado` VARCHAR(45) NULL,
  `apellidoEntrevistado` VARCHAR(45) NULL,
  `puesto` VARCHAR(45) NULL,
  `ID.Usuario` INT NOT NULL,
  `idEmpleado` INT NOT NULL,
  PRIMARY KEY (`idEntrevista`),
    FOREIGN KEY (`Usuario_ID.Usuario`,`idEmpleado`)
)

CREATE TABLE `BDIPC2`.`Vehiculo` (
  `Placa` INT NOT NULL,
  `Modelo` INT NULL,
  `Marca` VARCHAR(45) NULL,
  `Año` DATE NULL,
  PRIMARY KEY (`Placa`),
)

CREATE TABLE `BDIPC2`.`Piloto` (
  `idPiloto` INT NOT NULL,
  `No.licencia` VARCHAR(45) NULL,
  `CUI` INT NOT NULL,
  PRIMARY KEY (`idPiloto`),
    FOREIGN KEY (`CUI`)
)

CREATE TABLE `BDIPC2`.`Acompañante` (
  `idAcompañante` INT NOT NULL,
  `CUI` INT NOT NULL,
  PRIMARY KEY (`idAcompañante`),
    FOREIGN KEY (`CUI`)
)

CREATE TABLE `BDIPC2`.`Viaje` (
  `idViaje` INT NOT NULL,
  `idPiloto` INT NOT NULL,
  `idAcompañante` INT NOT NULL,
  `Placa` INT NOT NULL,
  `Direccion` VARCHAR(45) NULL,
  `Distancia` DOUBLE NULL,
  `FechaSalida` VARCHAR(45) NULL,
  `FechaLlegada` VARCHAR(45) NULL,
  PRIMARY KEY (`idViaje`),
    FOREIGN KEY (`idPiloto`,`idAcompañante`,`Placa`)
)

CREATE TABLE `BDIPC2`.`Anuncio` (
  `idAnuncio` INT NOT NULL,
  `titulo` VARCHAR(45) NULL,
  `descripcion` VARCHAR(100) NULL,
  `ID.Usuario` INT NOT NULL,
  PRIMARY KEY (`idAnuncio`),
    FOREIGN KEY (`ID.Usuario`)
)

CREATE TABLE `BDIPC2`.`Oportunidad` (
  `idOportunidad` INT NOT NULL,
  `titulo` VARCHAR(45) NULL,
  `cantidadIngreso` VARCHAR(45) NULL,
  `Prioridad` VARCHAR(45) NULL,
  `idCliente` INT NOT NULL,
  `ID.Usuario` INT NOT NULL,
  PRIMARY KEY (`idOportunidad`),
    FOREIGN KEY (`idCliente`,`ID.Usuario`)
)

CREATE TABLE `BDIPC2`.`Eventos` (
  `idEvento` INT NOT NULL,
  `titulo` VARCHAR(45) NULL,
  `descripcion` VARCHAR(603) NULL,
  `fecha` DATE NULL,
  `estado` VARCHAR(45) NULL,
  `ID.Usuario` INT NOT NULL,
  PRIMARY KEY (`idEvento`),
  	FOREIGN KEY (`ID.Usuario`)
)

CREATE TABLE `BDIPC2`.`Asistencia` (
  `idAsistencia` INT NOT NULL,
  `horaEntrada` TIME NOT NULL,
  `HoraSalida` TIME NOT NULL,
  `Fecha` DATE NOT NULL,
  `CUI` INT NOT NULL,
  PRIMARY KEY (`idAsistencia`),
    FOREIGN KEY (`CUI`)
)

CREATE TABLE `BDIPC2`.`ViajeProducto` (
  `idViaje` INT NOT NULL,
  `idProducto` INT NOT NULL,
  PRIMARY KEY (`idViaje`,`idProducto`),
    FOREIGN KEY (`idViaje` , `idProducto`)
)

CREATE TABLE `BDIPC2`.`Comentario` (
  `idComentario` INT NOT NULL,
  `descripcion` VARCHAR(100) NULL,
  `idAnuncio` INT NOT NULL,
  PRIMARY KEY (`idComentario`),
    FOREIGN KEY (`idAnuncio`)
)


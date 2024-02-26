-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 26-02-2024 a las 18:31:59
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `academia`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `alumnos`
--

CREATE TABLE `alumnos` (
  `id_alumno` int(11) NOT NULL,
  `nombre` varchar(40) NOT NULL,
  `apellidos` varchar(40) NOT NULL,
  `id_genero` int(11) NOT NULL,
  `fecha_nacimiento` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `alumnos`
--

INSERT INTO `alumnos` (`id_alumno`, `nombre`, `apellidos`, `id_genero`, `fecha_nacimiento`) VALUES
(1, 'Juan', 'Perez Valgañon', 1, '1980-02-07'),
(2, 'Miguel', 'Perez García', 1, '1983-01-18'),
(3, 'Susana', 'Perez Saenz', 2, '1990-03-30'),
(4, 'Carmen', 'Puente Mancebo', 2, '1960-09-15'),
(5, 'Alberto', 'de la Serna Parada', 1, '1984-03-27'),
(6, 'Jose Manuel', 'Pinillos Rubio', 1, '1656-04-15'),
(7, 'Pedro', 'Matias Jadraque', 1, '1985-08-27'),
(8, 'Felisa', 'Viguera Moreno', 2, '1988-12-08'),
(9, 'Javier', 'Jimenez Jimenez', 1, '1991-07-29'),
(10, 'Alina', 'Sanz Segura', 2, '1981-02-22');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asignaturas`
--

CREATE TABLE `asignaturas` (
  `id_asignaturas` int(11) NOT NULL,
  `id_departamento` int(11) DEFAULT NULL,
  `creditos` int(11) NOT NULL,
  `nombre` varchar(40) NOT NULL,
  `descripción` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `asignaturas`
--

INSERT INTO `asignaturas` (`id_asignaturas`, `id_departamento`, `creditos`, `nombre`, `descripción`) VALUES
(1, 1, 6, 'Programación Avanzada', 'Curso avanzado de programación.'),
(2, 1, 6, 'Bases de Datos', 'Estudio de sistemas de gestión de bases de datos.'),
(3, 2, 6, 'Química Orgánica', 'Fundamentos y aplicaciones de la química orgánica.'),
(4, 2, 6, 'Física Cuántica', 'Introducción a los principios de la física cuántica.'),
(5, 3, 6, 'Nutrición y Salud', 'Estudio sobre la nutrición y su impacto en la salud.'),
(6, 4, 3, 'Anatomía Humana', 'Estudio detallado de la anatomía del cuerpo humano.'),
(7, 5, 3, 'Farmacología', 'Principios y aplicaciones de la farmacología.'),
(8, 6, 6, 'Cálculo Diferencial', 'Conceptos fundamentales del cálculo diferencial.'),
(9, 7, 6, 'Patología General', 'Estudio de las enfermedades y sus efectos en el cuerpo.'),
(10, 3, 3, 'Salud Pública', 'Aspectos fundamentales de la salud pública y su gestión.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `departamentos`
--

CREATE TABLE `departamentos` (
  `id_departamento` int(11) NOT NULL,
  `nombre` varchar(40) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `departamentos`
--

INSERT INTO `departamentos` (`id_departamento`, `nombre`) VALUES
(1, 'Informática'),
(2, 'Ciencias'),
(3, 'Salud'),
(4, 'Anatomía'),
(5, 'Medicína'),
(6, 'Matemáticas'),
(7, 'Medicina');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `departamento_profesor`
--

CREATE TABLE `departamento_profesor` (
  `id_departamento` int(11) NOT NULL,
  `id_profesor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `departamento_profesor`
--

INSERT INTO `departamento_profesor` (`id_departamento`, `id_profesor`) VALUES
(1, 2),
(1, 7),
(2, 8),
(3, 1),
(3, 5),
(3, 10),
(4, 6),
(5, 4),
(5, 9),
(7, 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `direccion_departamento`
--

CREATE TABLE `direccion_departamento` (
  `id_departamento` int(11) NOT NULL,
  `id_profesor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `direccion_departamento`
--

INSERT INTO `direccion_departamento` (`id_departamento`, `id_profesor`) VALUES
(1, 7),
(2, 8),
(3, 1),
(4, 6),
(5, 4),
(6, 9),
(7, 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `genero`
--

CREATE TABLE `genero` (
  `id_genero` int(11) NOT NULL,
  `genero` enum('Masculino','Femenino') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `genero`
--

INSERT INTO `genero` (`id_genero`, `genero`) VALUES
(1, 'Masculino'),
(2, 'Femenino');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `impartir`
--

CREATE TABLE `impartir` (
  `id_alumno` int(11) NOT NULL,
  `id_asignatura` int(11) NOT NULL,
  `id_profesor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `impartir`
--

INSERT INTO `impartir` (`id_alumno`, `id_asignatura`, `id_profesor`) VALUES
(1, 2, 3),
(1, 5, 2),
(2, 1, 3),
(2, 3, 4),
(3, 1, 5),
(3, 4, 1),
(4, 3, 5),
(4, 7, 2),
(5, 2, 4),
(5, 8, 1),
(6, 7, 3),
(7, 6, 2),
(8, 9, 1),
(9, 8, 4),
(10, 10, 5);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `matriculas`
--

CREATE TABLE `matriculas` (
  `importe` double NOT NULL,
  `id_alumno` int(11) NOT NULL,
  `id_asignatura` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `matriculas`
--

INSERT INTO `matriculas` (`importe`, `id_alumno`, `id_asignatura`) VALUES
(550, 1, 2),
(500, 1, 3),
(500, 2, 1),
(650, 2, 4),
(700, 3, 1),
(600, 3, 3),
(450, 4, 2),
(450, 4, 4),
(550, 5, 5),
(600, 5, 6),
(500, 6, 6),
(650, 7, 7),
(550, 8, 8),
(700, 9, 9),
(550, 10, 10);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `profesores`
--

CREATE TABLE `profesores` (
  `id_profesor` int(11) NOT NULL,
  `nombre` varchar(40) NOT NULL,
  `apellidos` varchar(40) NOT NULL,
  `fecha_nacimiento` date DEFAULT NULL,
  `id_genero` int(11) NOT NULL,
  `id_departamento` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `profesores`
--

INSERT INTO `profesores` (`id_profesor`, `nombre`, `apellidos`, `fecha_nacimiento`, `id_genero`, `id_departamento`) VALUES
(1, 'Luis', 'Pedraza Gomara', '1975-03-15', 1, 3),
(2, 'Alfonso', 'de la Orden Lopez', '1970-12-25', 1, 1),
(3, 'María Teresa', 'Saenz López', '1969-06-18', 2, 7),
(4, 'Susana', 'Quiros Arnedo', '1973-06-27', 2, 5),
(5, 'Carlos', 'Gomez Fernandez', '1980-04-15', 1, 3),
(6, 'María', 'Lopez Ruiz', '1975-08-22', 2, 4),
(7, 'Juan', 'Martinez Soler', '1982-01-30', 1, 1),
(8, 'Ana', 'Jimenez Lago', '1978-03-05', 2, 2),
(9, 'Luis', 'Perez Giraldo', '1969-11-12', 1, 5),
(10, 'Sofía', 'Morales Díaz', '1985-07-19', 2, 3);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `alumnos`
--
ALTER TABLE `alumnos`
  ADD PRIMARY KEY (`id_alumno`),
  ADD KEY `alumnos_genero_id_genero_fk` (`id_genero`);

--
-- Indices de la tabla `asignaturas`
--
ALTER TABLE `asignaturas`
  ADD PRIMARY KEY (`id_asignaturas`),
  ADD KEY `asignaturas_departamentos_id_departamento_fk` (`id_departamento`);

--
-- Indices de la tabla `departamentos`
--
ALTER TABLE `departamentos`
  ADD PRIMARY KEY (`id_departamento`);

--
-- Indices de la tabla `departamento_profesor`
--
ALTER TABLE `departamento_profesor`
  ADD PRIMARY KEY (`id_departamento`,`id_profesor`),
  ADD KEY `departamento_profesor_profesores_id_profesor_fk` (`id_profesor`);

--
-- Indices de la tabla `direccion_departamento`
--
ALTER TABLE `direccion_departamento`
  ADD PRIMARY KEY (`id_departamento`,`id_profesor`),
  ADD KEY `direccion_departamento_profesores_id_profesor_fk` (`id_profesor`);

--
-- Indices de la tabla `genero`
--
ALTER TABLE `genero`
  ADD PRIMARY KEY (`id_genero`);

--
-- Indices de la tabla `impartir`
--
ALTER TABLE `impartir`
  ADD PRIMARY KEY (`id_alumno`,`id_asignatura`,`id_profesor`),
  ADD KEY `impartir_asignaturas_id_asignaturas_fk` (`id_asignatura`),
  ADD KEY `impartir_profesores_id_profesor_fk` (`id_profesor`);

--
-- Indices de la tabla `matriculas`
--
ALTER TABLE `matriculas`
  ADD PRIMARY KEY (`id_alumno`,`id_asignatura`),
  ADD KEY `matriculas_asignaturas_id_asignaturas_fk` (`id_asignatura`);

--
-- Indices de la tabla `profesores`
--
ALTER TABLE `profesores`
  ADD PRIMARY KEY (`id_profesor`),
  ADD KEY `profesores_departamentos_id_departamento_fk` (`id_departamento`),
  ADD KEY `profesores_genero_id_genero_fk` (`id_genero`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `alumnos`
--
ALTER TABLE `alumnos`
  MODIFY `id_alumno` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de la tabla `asignaturas`
--
ALTER TABLE `asignaturas`
  MODIFY `id_asignaturas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de la tabla `departamentos`
--
ALTER TABLE `departamentos`
  MODIFY `id_departamento` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `genero`
--
ALTER TABLE `genero`
  MODIFY `id_genero` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `profesores`
--
ALTER TABLE `profesores`
  MODIFY `id_profesor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `alumnos`
--
ALTER TABLE `alumnos`
  ADD CONSTRAINT `alumnos_genero_id_genero_fk` FOREIGN KEY (`id_genero`) REFERENCES `genero` (`id_genero`);

--
-- Filtros para la tabla `asignaturas`
--
ALTER TABLE `asignaturas`
  ADD CONSTRAINT `asignaturas_departamentos_id_departamento_fk` FOREIGN KEY (`id_departamento`) REFERENCES `departamentos` (`id_departamento`);

--
-- Filtros para la tabla `departamento_profesor`
--
ALTER TABLE `departamento_profesor`
  ADD CONSTRAINT `departamento_profesor_departamentos_id_departamento_fk` FOREIGN KEY (`id_departamento`) REFERENCES `departamentos` (`id_departamento`),
  ADD CONSTRAINT `departamento_profesor_profesores_id_profesor_fk` FOREIGN KEY (`id_profesor`) REFERENCES `profesores` (`id_profesor`);

--
-- Filtros para la tabla `direccion_departamento`
--
ALTER TABLE `direccion_departamento`
  ADD CONSTRAINT `direccion_departamento_departamentos_id_departamento_fk` FOREIGN KEY (`id_departamento`) REFERENCES `departamentos` (`id_departamento`),
  ADD CONSTRAINT `direccion_departamento_profesores_id_profesor_fk` FOREIGN KEY (`id_profesor`) REFERENCES `profesores` (`id_profesor`);

--
-- Filtros para la tabla `impartir`
--
ALTER TABLE `impartir`
  ADD CONSTRAINT `impartir_alumnos_id_alumno_fk` FOREIGN KEY (`id_alumno`) REFERENCES `alumnos` (`id_alumno`),
  ADD CONSTRAINT `impartir_asignaturas_id_asignaturas_fk` FOREIGN KEY (`id_asignatura`) REFERENCES `asignaturas` (`id_asignaturas`),
  ADD CONSTRAINT `impartir_profesores_id_profesor_fk` FOREIGN KEY (`id_profesor`) REFERENCES `profesores` (`id_profesor`);

--
-- Filtros para la tabla `matriculas`
--
ALTER TABLE `matriculas`
  ADD CONSTRAINT `matriculas_alumnos_id_alumno_fk` FOREIGN KEY (`id_alumno`) REFERENCES `alumnos` (`id_alumno`),
  ADD CONSTRAINT `matriculas_asignaturas_id_asignaturas_fk` FOREIGN KEY (`id_asignatura`) REFERENCES `asignaturas` (`id_asignaturas`);

--
-- Filtros para la tabla `profesores`
--
ALTER TABLE `profesores`
  ADD CONSTRAINT `profesores_departamentos_id_departamento_fk` FOREIGN KEY (`id_departamento`) REFERENCES `departamentos` (`id_departamento`),
  ADD CONSTRAINT `profesores_genero_id_genero_fk` FOREIGN KEY (`id_genero`) REFERENCES `genero` (`id_genero`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

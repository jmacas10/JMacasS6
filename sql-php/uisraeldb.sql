
SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";



--
-- Base de datos: `uisraeldb`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estudiante`
--

CREATE TABLE `estudiante` (
  `cod` int(11) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `apellido` varchar(30) NOT NULL,
  `edad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `estudiante`
--

INSERT INTO `estudiante` (`cod`, `nombre`, `apellido`, `edad`) VALUES
(1, 'Johnny', 'Macas', 32),
(2, 'Chris', 'Garcia', 38),
(3, 'nelly', 'arias', 25),
(4, 'evelyn', 'Smith', 23),
(5, 'silvis', 'Johnson', 22),
(6, 'moni', 'quezada', 28),
(7, 'karina', 'piclco', 29),
(8, 'andrea', 'cevallos', 28),
(9, 'vilma', 'luna', 33),
(10, 'mirian', 'bueno', 31),
(11, 'jessica', 'llivisa', 35);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `estudiante`
--
ALTER TABLE `estudiante`
  ADD PRIMARY KEY (`cod`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `estudiante`
--
ALTER TABLE `estudiante`
  MODIFY `cod` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;



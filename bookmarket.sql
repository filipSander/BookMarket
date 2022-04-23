-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Мар 28 2022 г., 12:20
-- Версия сервера: 5.7.33
-- Версия PHP: 7.4.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `bookmarket`
--

-- --------------------------------------------------------

--
-- Структура таблицы `arrivalgoods`
--

CREATE TABLE `arrivalgoods` (
  `ArrivalID` int(11) NOT NULL,
  `Date` varchar(20) DEFAULT NULL,
  `Sum` varchar(20) DEFAULT NULL,
  `CounterpartyID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `compositionregistration`
--

CREATE TABLE `compositionregistration` (
  `RelationID` int(11) NOT NULL,
  `Count` int(11) DEFAULT NULL,
  `Summ` varchar(20) DEFAULT NULL,
  `ProductID` int(11) DEFAULT NULL,
  `RealizationID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `contentsdelivery`
--

CREATE TABLE `contentsdelivery` (
  `RelationID` int(11) NOT NULL,
  `ArrivalID` int(11) DEFAULT NULL,
  `ProductID` int(11) DEFAULT NULL,
  `Count` int(11) DEFAULT NULL,
  `Summ` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `counterparty`
--

CREATE TABLE `counterparty` (
  `CounterpartyID` int(11) NOT NULL,
  `Type` varchar(40) DEFAULT NULL,
  `Form` varchar(40) DEFAULT NULL,
  `Name` varchar(300) DEFAULT NULL,
  `Address` varchar(300) DEFAULT NULL,
  `ContactPhone` varchar(120) DEFAULT NULL,
  `Requisites` varchar(300) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `counterparty`
--

INSERT INTO `counterparty` (`CounterpartyID`, `Type`, `Form`, `Name`, `Address`, `ContactPhone`, `Requisites`) VALUES
(0, 'Клиент', 'Физическое лицо', 'Частное лицо', '', '', 'Для розничной продажи'),
(3, 'Поставщик', 'Физическое лицо', 'asd', 'asdas', '13', 'sdd'),
(4, 'Клиент', 'Физическое лицо', '312', '', '', ''),
(5, 'Поставщик', 'Физическое лицо', '231', '', '', '');

-- --------------------------------------------------------

--
-- Структура таблицы `groupproduct`
--

CREATE TABLE `groupproduct` (
  `GroupID` int(11) NOT NULL,
  `Name` varchar(300) DEFAULT NULL,
  `Description` varchar(120) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `groupproduct`
--

INSERT INTO `groupproduct` (`GroupID`, `Name`, `Description`) VALUES
(0, 'Группа 1', '\n'),
(1, 'Группа 2', '\n');

-- --------------------------------------------------------

--
-- Структура таблицы `product`
--

CREATE TABLE `product` (
  `ProductID` int(11) NOT NULL,
  `Name` varchar(300) DEFAULT NULL,
  `purchasePrice` int(11) DEFAULT NULL,
  `PriceRealizations` int(11) DEFAULT NULL,
  `UMeasurement` varchar(20) DEFAULT NULL,
  `CountStock` int(11) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `product`
--

INSERT INTO `product` (`ProductID`, `Name`, `purchasePrice`, `PriceRealizations`, `UMeasurement`, `CountStock`) VALUES
(0, 'Товар 1', 100, 200, 'шт', 7),
(1, 'Товар 2', 100, 200, '', 11),
(2, 'asd', 100, 100, '', 2),
(3, '1', 100, 100, '', 1),
(4, '123', 100, 100, '', 0);

-- --------------------------------------------------------

--
-- Структура таблицы `productgroupproduct`
--

CREATE TABLE `productgroupproduct` (
  `GroupID` int(11) NOT NULL,
  `ProductID` int(11) DEFAULT NULL,
  `СonnID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `productgroupproduct`
--

INSERT INTO `productgroupproduct` (`GroupID`, `ProductID`, `СonnID`) VALUES
(0, 2, 0),
(1, 2, 1),
(0, 3, 2),
(1, 3, 3),
(0, 4, 4),
(1, 4, 5);

-- --------------------------------------------------------

--
-- Структура таблицы `props`
--

CREATE TABLE `props` (
  `PropsID` int(11) NOT NULL,
  `Name` varchar(120) DEFAULT NULL,
  `Value` varchar(120) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `props`
--

INSERT INTO `props` (`PropsID`, `Name`, `Value`) VALUES
(0, 'Наименование организации', 'читай город'),
(1, 'Юридический адрес', '---'),
(2, 'Контактный телефон', '9(123)-123-21-32'),
(3, 'Банковские реквизиты', 'p/c 13124342341341 k/s 12414432423432'),
(4, 'ИНН', 'BYY'),
(5, 'КПП', 'KPP');

-- --------------------------------------------------------

--
-- Структура таблицы `realizationgoods`
--

CREATE TABLE `realizationgoods` (
  `RealizationID` int(11) NOT NULL,
  `CounterpartyID` int(11) DEFAULT NULL,
  `Date` varchar(20) DEFAULT NULL,
  `Sum` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `userID` int(11) NOT NULL,
  `login` varchar(13) DEFAULT NULL,
  `password` varchar(29) DEFAULT NULL,
  `accessLevel` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`userID`, `login`, `password`, `accessLevel`) VALUES
(1, 'admin', '0DPiKuNIrrVmD8IUCuw1hQxNqZc=', 1),
(2, 'special', 'uja5ekHn+vdCqwm/iEBawE+ZWZo=', 2),
(3, 'user', 'Et6pb+wgWTVmq3VpLJlJWWgzrck=', 3);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `arrivalgoods`
--
ALTER TABLE `arrivalgoods`
  ADD PRIMARY KEY (`ArrivalID`),
  ADD KEY `R_5` (`CounterpartyID`);

--
-- Индексы таблицы `compositionregistration`
--
ALTER TABLE `compositionregistration`
  ADD PRIMARY KEY (`RelationID`),
  ADD KEY `R_28` (`ProductID`),
  ADD KEY `R_29` (`RealizationID`);

--
-- Индексы таблицы `contentsdelivery`
--
ALTER TABLE `contentsdelivery`
  ADD PRIMARY KEY (`RelationID`),
  ADD KEY `R_26` (`ArrivalID`),
  ADD KEY `R_27` (`ProductID`);

--
-- Индексы таблицы `counterparty`
--
ALTER TABLE `counterparty`
  ADD PRIMARY KEY (`CounterpartyID`);

--
-- Индексы таблицы `groupproduct`
--
ALTER TABLE `groupproduct`
  ADD PRIMARY KEY (`GroupID`);

--
-- Индексы таблицы `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`ProductID`);

--
-- Индексы таблицы `productgroupproduct`
--
ALTER TABLE `productgroupproduct`
  ADD PRIMARY KEY (`СonnID`),
  ADD KEY `R_23` (`GroupID`),
  ADD KEY `R_24` (`ProductID`);

--
-- Индексы таблицы `props`
--
ALTER TABLE `props`
  ADD PRIMARY KEY (`PropsID`);

--
-- Индексы таблицы `realizationgoods`
--
ALTER TABLE `realizationgoods`
  ADD PRIMARY KEY (`RealizationID`),
  ADD KEY `R_7` (`CounterpartyID`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`userID`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `userID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `arrivalgoods`
--
ALTER TABLE `arrivalgoods`
  ADD CONSTRAINT `arrivalgoods_ibfk_1` FOREIGN KEY (`CounterpartyID`) REFERENCES `counterparty` (`CounterpartyID`);

--
-- Ограничения внешнего ключа таблицы `compositionregistration`
--
ALTER TABLE `compositionregistration`
  ADD CONSTRAINT `compositionregistration_ibfk_1` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ProductID`),
  ADD CONSTRAINT `compositionregistration_ibfk_2` FOREIGN KEY (`RealizationID`) REFERENCES `realizationgoods` (`RealizationID`);

--
-- Ограничения внешнего ключа таблицы `contentsdelivery`
--
ALTER TABLE `contentsdelivery`
  ADD CONSTRAINT `contentsdelivery_ibfk_1` FOREIGN KEY (`ArrivalID`) REFERENCES `arrivalgoods` (`ArrivalID`),
  ADD CONSTRAINT `contentsdelivery_ibfk_2` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ProductID`);

--
-- Ограничения внешнего ключа таблицы `productgroupproduct`
--
ALTER TABLE `productgroupproduct`
  ADD CONSTRAINT `productgroupproduct_ibfk_1` FOREIGN KEY (`GroupID`) REFERENCES `groupproduct` (`GroupID`),
  ADD CONSTRAINT `productgroupproduct_ibfk_2` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ProductID`);

--
-- Ограничения внешнего ключа таблицы `realizationgoods`
--
ALTER TABLE `realizationgoods`
  ADD CONSTRAINT `realizationgoods_ibfk_1` FOREIGN KEY (`CounterpartyID`) REFERENCES `counterparty` (`CounterpartyID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

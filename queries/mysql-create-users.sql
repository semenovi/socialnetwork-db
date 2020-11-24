CREATE TABLE `Пользователи` (
	`id` varchar(8) NOT NULL AUTO_INCREMENT,
	`Фамилия` VARCHAR(32),
	`Имя` VARCHAR(32) NOT NULL,
	`Отчество` VARCHAR(32),
	`Пол` varchar(1),
	`Дата рождения` DATE,
	`Страна` VARCHAR(32),
	`Город` VARCHAR(32),
	`Телефон` VARCHAR(10),
	`Аватар` VARCHAR(12),
	`О себе` VARCHAR(256),
	`Пароль` VARCHAR(256) NOT NULL,
	`Отображение пола` varchar(1) NOT NULL,
	`Отображение дня рождения` varchar(1) NOT NULL,
	`Отображение аватара` varchar(1) NOT NULL,
	`Отображение друзей` varchar(1) NOT NULL,
	`Отображение групп` varchar(1) NOT NULL,
	`Отображение записей` varchar(1) NOT NULL,
	`Отображение сообщений` varchar(1) NOT NULL,
	`Уведомления` varchar(1) NOT NULL,
	`Звуки` varchar(1) NOT NULL,
	`Содержимое` varchar(1) NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `Друзья` (
	`id пользователя` varchar(8) NOT NULL AUTO_INCREMENT,
	`id друга` varchar(8) NOT NULL AUTO_INCREMENT,
	PRIMARY KEY (`id пользователя`,`id друга`)
);

CREATE TABLE `Исходящие заявки` (
	`id пользователя` varchar(8) NOT NULL AUTO_INCREMENT,
	`id получателя` varchar(8) NOT NULL AUTO_INCREMENT,
	PRIMARY KEY (`id пользователя`,`id получателя`)
);

CREATE TABLE `Входящие заявки` (
	`id пользователя` varchar(8) NOT NULL AUTO_INCREMENT,
	`id отправителя` varchar(8) NOT NULL AUTO_INCREMENT,
	PRIMARY KEY (`id пользователя`,`id отправителя`)
);

CREATE TABLE `Классы id` (
	`id` varchar(8) NOT NULL AUTO_INCREMENT,
	`Класс` varchar(1) NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `Группы` (
	`id` varchar(8) NOT NULL AUTO_INCREMENT,
	`Название` varchar(32) NOT NULL,
	`Аватар` varchar(12),
	`id владельца` varchar(12) NOT NULL,
	`О группе` varchar(256),
	PRIMARY KEY (`id`)
);

CREATE TABLE `Записи` (
	`id записи` varchar(8) NOT NULL AUTO_INCREMENT,
	`id` varchar(8) NOT NULL,
	PRIMARY KEY (`id записи`)
);

CREATE TABLE `Подписки` (
	`id пользователя` varchar(8) NOT NULL,
	`id группы` varchar(8) NOT NULL,
	PRIMARY KEY (`id пользователя`,`id группы`)
);

CREATE TABLE `Оцененные записи` (
	`id пользователя` varchar(8) NOT NULL,
	`id записи` varchar(8) NOT NULL,
	PRIMARY KEY (`id пользователя`,`id записи`)
);

CREATE TABLE `Документы записей` (
	`id записи` varchar(8) NOT NULL,
	`Документ` varchar(12) NOT NULL,
	PRIMARY KEY (`id записи`,`Документ`)
);

CREATE TABLE `Сообщения` (
	`id сообщения` varchar(8) NOT NULL AUTO_INCREMENT,
	`id отправителя` varchar(8) NOT NULL,
	`id получателя` varchar(8) NOT NULL,
	`Текст сообщения` varchar(256) NOT NULL,
	PRIMARY KEY (`id сообщения`)
);

CREATE TABLE `Документы сообщений` (
	`id сообщения` varchar(8) NOT NULL,
	`Документ` varchar(12) NOT NULL,
	PRIMARY KEY (`id сообщения`,`Документ`)
);

ALTER TABLE `Пользователи` ADD CONSTRAINT `Пользователи_fk0` FOREIGN KEY (`id`) REFERENCES `Классы id`(`id`);

ALTER TABLE `Друзья` ADD CONSTRAINT `Друзья_fk0` FOREIGN KEY (`id пользователя`) REFERENCES `Пользователи`(`id`);

ALTER TABLE `Друзья` ADD CONSTRAINT `Друзья_fk1` FOREIGN KEY (`id друга`) REFERENCES `Пользователи`(`id`);

ALTER TABLE `Исходящие заявки` ADD CONSTRAINT `Исходящие заявки_fk0` FOREIGN KEY (`id пользователя`) REFERENCES `Пользователи`(`id`);

ALTER TABLE `Исходящие заявки` ADD CONSTRAINT `Исходящие заявки_fk1` FOREIGN KEY (`id получателя`) REFERENCES `Пользователи`(`id`);

ALTER TABLE `Входящие заявки` ADD CONSTRAINT `Входящие заявки_fk0` FOREIGN KEY (`id пользователя`) REFERENCES `Пользователи`(`id`);

ALTER TABLE `Входящие заявки` ADD CONSTRAINT `Входящие заявки_fk1` FOREIGN KEY (`id отправителя`) REFERENCES `Пользователи`(`id`);

ALTER TABLE `Группы` ADD CONSTRAINT `Группы_fk0` FOREIGN KEY (`id`) REFERENCES `Классы id`(`id`);

ALTER TABLE `Группы` ADD CONSTRAINT `Группы_fk1` FOREIGN KEY (`id владельца`) REFERENCES `Пользователи`(`id`);

ALTER TABLE `Записи` ADD CONSTRAINT `Записи_fk0` FOREIGN KEY (`id записи`) REFERENCES `Классы id`(`id`);

ALTER TABLE `Записи` ADD CONSTRAINT `Записи_fk1` FOREIGN KEY (`id`) REFERENCES `Классы id`(`id`);

ALTER TABLE `Подписки` ADD CONSTRAINT `Подписки_fk0` FOREIGN KEY (`id пользователя`) REFERENCES `Пользователи`(`id`);

ALTER TABLE `Подписки` ADD CONSTRAINT `Подписки_fk1` FOREIGN KEY (`id группы`) REFERENCES `Группы`(`id`);

ALTER TABLE `Оцененные записи` ADD CONSTRAINT `Оцененные записи_fk0` FOREIGN KEY (`id пользователя`) REFERENCES `Пользователи`(`id`);

ALTER TABLE `Оцененные записи` ADD CONSTRAINT `Оцененные записи_fk1` FOREIGN KEY (`id записи`) REFERENCES `Записи`(`id записи`);

ALTER TABLE `Документы записей` ADD CONSTRAINT `Документы записей_fk0` FOREIGN KEY (`id записи`) REFERENCES `Записи`(`id записи`);

ALTER TABLE `Сообщения` ADD CONSTRAINT `Сообщения_fk0` FOREIGN KEY (`id отправителя`) REFERENCES `Пользователи`(`id`);

ALTER TABLE `Сообщения` ADD CONSTRAINT `Сообщения_fk1` FOREIGN KEY (`id получателя`) REFERENCES `Пользователи`(`id`);

ALTER TABLE `Документы сообщений` ADD CONSTRAINT `Документы сообщений_fk0` FOREIGN KEY (`id сообщения`) REFERENCES `Сообщения`(`id сообщения`);


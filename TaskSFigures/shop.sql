CREATE TABLE `categories` (
  `id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `catname` varchar(35) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `categories` VALUES (1,'Продукты'),(2,'Бытовая химия'),(3,'Фрукты'),(4,'Канцелярия');

CREATE TABLE `products` (
  `id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(25) NOT NULL,
  `category` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `products` VALUES (1,'Хлеб',1),(2,'Молоко',1),(3,'Картошка',1),(4,'Мыло',2),(5,'Дезодорант',2),(6,'Шампунь',2),(7,'Яблоки',3),(8,'Лимоны',3),(9,'Апельсины',3),(10,'Ручка',4),(11,'Тетрадь',4),(12,'Ножницы',4),(13,'Телескоп',NULL),(14,'Костюм единорога',NULL);

select products.name Товар, categories.catname Категория from products left join categories on products.category=categories.id;
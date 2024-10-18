CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),  -- Уникальный идентификатор для каждой записи
    email NVARCHAR(255) NOT NULL UNIQUE,  -- Уникальный адрес электронной почты, обязательное поле
    login NVARCHAR(15) NOT NULL UNIQUE,   -- Уникальный логин, обязательное поле
    password NVARCHAR(56) NOT NULL,      -- Пароль, обязательное поле
    name NVARCHAR(10),                   -- Имя, может быть пустым
    surname NVARCHAR(15),                -- Фамилия, может быть пустым
    access INT DEFAULT 0                  -- Поле доступа, по умолчанию значение 0
);

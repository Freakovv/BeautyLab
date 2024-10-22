CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),      -- Уникальный идентификатор
    email NVARCHAR(255) NOT NULL UNIQUE,   -- Уникальный email
    login NVARCHAR(15) NULL,               -- Логин (необязательно)
    password NVARCHAR(64) NOT NULL,        -- Пароль
    name NVARCHAR(10),                     -- Имя (необязательно)
    surname NVARCHAR(15),                  -- Фамилия (необязательно)
    access INT DEFAULT 0                   -- Уровень доступа, по умолчанию 0
);

-- Создаем уникальный индекс только для непустых значений login
CREATE UNIQUE INDEX UQ_Users_Login_NotNull
ON Users (login)
WHERE login IS NOT NULL;

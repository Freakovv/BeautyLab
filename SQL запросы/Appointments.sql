CREATE TABLE Appointments
(
    ID INT IDENTITY(1,1) PRIMARY KEY,  -- ID будет уникальным и автоинкрементным
    FullName NVARCHAR(100),             -- ФИО
    Phone NVARCHAR(15),                 -- Телефон
    AppointmentDate DATE,               -- Дата записи
    AppointmentTime TIME,               -- Время записи
    Master NVARCHAR(100),               -- Мастер
    Service NVARCHAR(100),              -- Услуга
    Cost INT,                           -- Стоимость
    Status NVARCHAR(50)                -- Статус
);

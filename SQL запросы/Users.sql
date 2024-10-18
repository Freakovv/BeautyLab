CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),  -- ���������� ������������� ��� ������ ������
    email NVARCHAR(255) NOT NULL UNIQUE,  -- ���������� ����� ����������� �����, ������������ ����
    login NVARCHAR(15) NOT NULL UNIQUE,   -- ���������� �����, ������������ ����
    password NVARCHAR(56) NOT NULL,      -- ������, ������������ ����
    name NVARCHAR(10),                   -- ���, ����� ���� ������
    surname NVARCHAR(15),                -- �������, ����� ���� ������
    access INT DEFAULT 0                  -- ���� �������, �� ��������� �������� 0
);

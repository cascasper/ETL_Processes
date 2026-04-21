create table Sales (
    SaleID integer PRIMARY KEY AUTOINCREMENT,
    Name text not null,
    Description text,
    Quantity integer default 0,
    Weight real,
    Height real,
    Width real
);
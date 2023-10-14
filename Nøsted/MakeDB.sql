-- Create and use the database
Create database if not exists webAppDatabase;
Use webAppDatabase;

-- Drop constraints
    alter table sjekklisteHydraulisk drop constraint sjekklisteHydraulisk_ibfk_1;
    alter table sjekklisteElektriskKommentar drop constraint sjekklisteElektriskKommentar_ibfk_1;
-- Drop tables
    drop table if exists sjekklisteMekanisk;
    drop table if exists sjekklisteHydraulisk;
    drop table if exists sjekklisteElektriskKommentar;
    
-- Create tables
Create table if not exists sjekklisteMekanisk
(
    sjekklisteID int not null auto_increment primary key,
    clutch varchar(14),
    bremser varchar(14),
    lagerForTrommel varchar(14),
    pto varchar(14),
    kjedestrammer varchar(14),
    pinionLager varchar(14),
    kileKjedehjul varchar(14)
);

Create table if not exists sjekklisteHydraulisk
(
    sjekklisteID_FK int not null primary key,
    sylinderLekkasje varchar(14),
    slangeSkade varchar(14),
    hydraullikBlokk varchar(14),
    oljeTank varchar(14),
    oljeGirboks varchar(14),
    ringsylinder varchar(14),
    bremseSylinder varchar(14),
    foreign key (sjekklisteID_FK) references sjekklisteMekanisk(sjekklisteID)
);

create table if not exists sjekklisteElektriskKommentar
(
    sjekklisteID_FK int not null primary key,
    ledningsNett varchar(14),
    testRadio varchar(14),
    testKnappekasse varchar(14),
    bar varchar(20),
    testVinsjKjørAlt varchar(50),
    trekkraftKN varchar(50),
    kommentar varchar(255),
    foreign key (sjekklisteID_FK) references sjekklisteHydraulisk(sjekklisteID_FK)
);
-- Insert data

-- select * from information_schema.TABLE_CONSTRAINTS

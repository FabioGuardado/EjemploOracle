/* EJECUTAR EN SYSTEM */
alter session set "_ORACLE_SCRIPT"=true;
create user ejemplo_ef_core identified by 123456;
default tablespace users quota unlimited on users;
grant connect, resource to ejemplo_ef_core;

create table categoria(
    id int not null,
    nombre varchar(50),
    constraint pk_categoria
        primary key (id)
);

commit;

create sequence categoria_seq start with 1 increment by 1 nocache nocycle;

create or replace trigger al_insertar_categoria before insert on categoria for each row
begin
    select categoria_seq.nextval into :new.id from dual;
end;

insert into categoria(nombre) values ('Articulos de Aseo');
insert into categoria(nombre) values ('Aparatos Electricos');
commit;

select * from categoria;
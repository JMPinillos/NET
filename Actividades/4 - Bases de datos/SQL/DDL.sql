create table if not exists departamentos
(
    id_departamento int auto_increment
        primary key,
    nombre          varchar(40) null
);

create table if not exists asignaturas
(
    id_asignaturas  int auto_increment
        primary key,
    id_departamento int          null,
    creditos        int          not null,
    nombre          varchar(40)  not null,
    descripción     varchar(250) null,
    constraint asignaturas_departamentos_id_departamento_fk
        foreign key (id_departamento) references departamentos (id_departamento)
);

create table if not exists genero
(
    id_genero int auto_increment
        primary key,
    genero    enum ('Masculino', 'Femenino') null
);

create table if not exists alumnos
(
    id_alumno        int auto_increment
        primary key,
    nombre           varchar(40) not null,
    apellidos        varchar(40) not null,
    id_genero        int         not null,
    fecha_nacimiento date        null,
    constraint alumnos_genero_id_genero_fk
        foreign key (id_genero) references genero (id_genero)
);

create table if not exists matriculas
(
    importe       double not null,
    id_alumno     int    not null,
    id_asignatura int    not null,
    primary key (id_alumno, id_asignatura),
    constraint matriculas_alumnos_id_alumno_fk
        foreign key (id_alumno) references alumnos (id_alumno),
    constraint matriculas_asignaturas_id_asignaturas_fk
        foreign key (id_asignatura) references asignaturas (id_asignaturas)
);

create table if not exists profesores
(
    id_profesor      int auto_increment
        primary key,
    nombre           varchar(40) not null,
    apellidos        varchar(40) not null,
    fecha_nacimiento date        null,
    id_genero        int         not null,    
    constraint profesores_genero_id_genero_fk
        foreign key (id_genero) references genero (id_genero)
);

create table if not exists departamento_profesor
(
    id_departamento int not null,
    id_profesor     int not null,
    primary key (id_departamento, id_profesor),
    constraint departamento_profesor_departamentos_id_departamento_fk
        foreign key (id_departamento) references departamentos (id_departamento),
    constraint departamento_profesor_profesores_id_profesor_fk
        foreign key (id_profesor) references profesores (id_profesor)
);

create table if not exists direccion_departamento
(
    id_departamento int not null,
    id_profesor     int not null,
    primary key (id_departamento, id_profesor),
    constraint direccion_departamento_departamentos_id_departamento_fk
        foreign key (id_departamento) references departamentos (id_departamento),
    constraint direccion_departamento_profesores_id_profesor_fk
        foreign key (id_profesor) references profesores (id_profesor)
);

create table if not exists impartir
(
    id_alumno     int not null,
    id_asignatura int not null,
    id_profesor   int not null,
    primary key (id_alumno, id_asignatura, id_profesor),
    constraint impartir_alumnos_id_alumno_fk
        foreign key (id_alumno) references alumnos (id_alumno),
    constraint impartir_asignaturas_id_asignaturas_fk
        foreign key (id_asignatura) references asignaturas (id_asignaturas),
    constraint impartir_profesores_id_profesor_fk
        foreign key (id_profesor) references profesores (id_profesor)
);
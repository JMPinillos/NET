-- INSERTAMOS DATOS EN LA TABLA GENERO
insert into academia.genero (id_genero, genero)
values  (1, 'Masculino'),
        (2, 'Femenino');

-- INSERTAMOS DATOS EN LA TABLA ALUMNOS
insert into academia.alumnos (id_alumno, nombre, apellidos, id_genero, fecha_nacimiento)
values  (1, 'Juan', 'Perez Valgañon', 1, '1980-02-07'),
        (2, 'Miguel', 'Perez García', 1, '1983-01-18'),
        (3, 'Susana', 'Perez Saenz', 2, '1990-03-30'),
        (4, 'Carmen', 'Puente Mancebo', 2, '1960-09-15'),
        (5, 'Alberto', 'de la Serna Parada', 1, '1984-03-27'),
        (6, 'Jose Manuel', 'Pinillos Rubio', 1, '1656-04-15'),
        (7, 'Pedro', 'Matias Jadraque', 1, '1985-08-27'),
        (8, 'Felisa', 'Viguera Moreno', 2, '1988-12-08'),
        (9, 'Javier', 'Jimenez Jimenez', 1, '1991-07-29'),
        (10, 'Alina', 'Sanz Segura', 2, '1981-02-22');

-- INSERTAMOS DATOS EN LA TABLA DEPARTAMENTOS
insert into academia.departamentos (id_departamento, nombre)
values  (1, 'Informática'),
        (2, 'Ciencias'),
        (3, 'Salud'),
        (4, 'Anatomía'),
        (5, 'Medicína'),
        (6, 'Matemáticas'),
        (7, 'Medicina'); 

-- INSERTAMOS DATOS EN LA TABLA PROFESORES
insert into academia.profesores (id_profesor, nombre, apellidos, fecha_nacimiento, id_genero)
values  (1, 'Luis', 'Pedraza Gomara', '1975-03-15', 1),
        (2, 'Alfonso', 'de la Orden Lopez', '1970-12-25', 1),
        (3, 'María Teresa', 'Saenz López', '1969-06-18', 2),
        (4, 'Susana', 'Quiros Arnedo', '1973-06-27', 2),
        (5, 'Carlos', 'Gomez Fernandez', '1980-04-15', 1),
        (6, 'María', 'Lopez Ruiz', '1975-08-22', 2),
        (7, 'Juan', 'Martinez Soler', '1982-01-30', 1),
        (8, 'Ana', 'Jimenez Lago', '1978-03-05', 2),
        (9, 'Luis', 'Perez Giraldo', '1969-11-12', 1),
        (10, 'Sofía', 'Morales Díaz', '1985-07-19', 2);

-- INSERTAMOS DATOS EN LA TABLA DEPARTAMENTO_PROFESOR
insert into academia.departamento_profesor (id_departamento, id_profesor)
values  (3, 1),
        (1, 2),
        (7, 3),
        (5, 4),
        (3, 5),
        (4, 6),
        (1, 7),
        (2, 8),
        (5, 9),
        (3, 10);

-- INSERTAMOS DATOS EN LA TABLA DIRECCION_DEPARTAMENTO
insert into academia.direccion_departamento (id_departamento, id_profesor)
values  (3, 1),
        (7, 3),
        (5, 4),
        (4, 6),
        (1, 7),
        (2, 8),
        (6, 9);

-- INSERTAMOS DATOS EN LA TABLA ASIGNATURAS
insert into academia.asignaturas (id_asignaturas, id_departamento, creditos, nombre, descripción)
values  (1, 1, 6, 'Programación Avanzada', 'Curso avanzado de programación.'),
        (2, 1, 6, 'Bases de Datos', 'Estudio de sistemas de gestión de bases de datos.'),
        (3, 2, 6, 'Química Orgánica', 'Fundamentos y aplicaciones de la química orgánica.'),
        (4, 2, 6, 'Física Cuántica', 'Introducción a los principios de la física cuántica.'),
        (5, 3, 6, 'Nutrición y Salud', 'Estudio sobre la nutrición y su impacto en la salud.'),
        (6, 4, 3, 'Anatomía Humana', 'Estudio detallado de la anatomía del cuerpo humano.'),
        (7, 5, 3, 'Farmacología', 'Principios y aplicaciones de la farmacología.'),
        (8, 6, 6, 'Cálculo Diferencial', 'Conceptos fundamentales del cálculo diferencial.'),
        (9, 7, 6, 'Patología General', 'Estudio de las enfermedades y sus efectos en el cuerpo.'),
        (10, 3, 3, 'Salud Pública', 'Aspectos fundamentales de la salud pública y su gestión.');

-- INSERTAMOS DATOS EN LA TABLA IMPARTIR
insert into academia.impartir (id_alumno, id_asignatura, id_profesor)
values  (2, 1, 3),
        (3, 1, 5),
        (1, 2, 3),
        (5, 2, 4),
        (2, 3, 4),
        (4, 3, 5),
        (3, 4, 1),
        (1, 5, 2),
        (7, 6, 2),
        (4, 7, 2),
        (6, 7, 3),
        (5, 8, 1),
        (9, 8, 4),
        (8, 9, 1),
        (10, 10, 5);

-- INSERTAMOS DATOS EN LA TABLA MATRICULAS
insert into academia.matriculas (importe, id_alumno, id_asignatura)
values  (550, 1, 2),
        (500, 1, 3),
        (500, 2, 1),
        (650, 2, 4),
        (700, 3, 1),
        (600, 3, 3),
        (450, 4, 2),
        (450, 4, 4),
        (550, 5, 5),
        (600, 5, 6),
        (500, 6, 6),
        (650, 7, 7),
        (550, 8, 8),
        (700, 9, 9),
        (550, 10, 10);
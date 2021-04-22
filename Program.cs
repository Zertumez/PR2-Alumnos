using System;
using System.Collections.Generic;

namespace PR2_Alumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear 40 alumnos.
            RegistroAlumnos alumno1 = new RegistroAlumnos(8001, "Pablo", "Ramírez");
            RegistroAlumnos alumno2 = new RegistroAlumnos(8002, "Lorenzo", "Zaragoza");
            RegistroAlumnos alumno3 = new RegistroAlumnos(8003, "Hajar", "Alamo");
            RegistroAlumnos alumno4 = new RegistroAlumnos(8004, "Ramona", "Hermoso");
            RegistroAlumnos alumno5 = new RegistroAlumnos(8005, "Samuel", "Cantero");
            RegistroAlumnos alumno6 = new RegistroAlumnos(8006, "Alfonso", "Estrada");
            RegistroAlumnos alumno7 = new RegistroAlumnos(8007, "Alejandro", "Casas");
            RegistroAlumnos alumno8 = new RegistroAlumnos(8008, "Claudia", "Almeida");
            RegistroAlumnos alumno9 = new RegistroAlumnos(8009, "María", "Durán");
            RegistroAlumnos alumno10 = new RegistroAlumnos(8010, "Aidé", "Castillo");
            RegistroAlumnos alumno11 = new RegistroAlumnos(8011, "Daniela", "Puertas");
            RegistroAlumnos alumno12 = new RegistroAlumnos(8012, "Angel", "Ortiz");
            RegistroAlumnos alumno13 = new RegistroAlumnos(8013, "Georgina", "Flores");
            RegistroAlumnos alumno14 = new RegistroAlumnos(8014, "Concepción", "Revilla");
            RegistroAlumnos alumno15 = new RegistroAlumnos(8015, "Iryna", "Cordero");
            RegistroAlumnos alumno16 = new RegistroAlumnos(8016, "Rogelio", "Costa");
            RegistroAlumnos alumno17 = new RegistroAlumnos(8017, "Paula", "Giron");
            RegistroAlumnos alumno18 = new RegistroAlumnos(8018, "Rafael", "Estrada");
            RegistroAlumnos alumno19 = new RegistroAlumnos(8019, "Anabel", "Molero");
            RegistroAlumnos alumno20 = new RegistroAlumnos(8020, "Anibal", "Sampedro");
            RegistroAlumnos alumno21 = new RegistroAlumnos(8021, "Iveth", "Porras");
            RegistroAlumnos alumno22 = new RegistroAlumnos(8022, "Cipriano", "Sanchez");
            RegistroAlumnos alumno23 = new RegistroAlumnos(8023, "Carolina", "Murcia");
            RegistroAlumnos alumno24 = new RegistroAlumnos(8024, "Caleb", "Ballesteros");
            RegistroAlumnos alumno25 = new RegistroAlumnos(8025, "Maximo", "Montilla");
            RegistroAlumnos alumno26 = new RegistroAlumnos(8026, "Adriana", "Duarte");
            RegistroAlumnos alumno27 = new RegistroAlumnos(8027, "Geraldine", "Nieto");
            RegistroAlumnos alumno28 = new RegistroAlumnos(8028, "Juan", "Chamorro");
            RegistroAlumnos alumno29 = new RegistroAlumnos(8029, "Bruno", "Díaz");
            RegistroAlumnos alumno30 = new RegistroAlumnos(8030, "Maite", "Marin");
            RegistroAlumnos alumno31 = new RegistroAlumnos(8031, "Ismael", "Díaz");
            RegistroAlumnos alumno32 = new RegistroAlumnos(8032, "Minerva", "Ponce");
            RegistroAlumnos alumno33 = new RegistroAlumnos(8033, "Mario", "Cuesta");
            RegistroAlumnos alumno34 = new RegistroAlumnos(8034, "Andrea", "Villa");
            RegistroAlumnos alumno35 = new RegistroAlumnos(8035, "Cesar", "Gómez");
            RegistroAlumnos alumno36 = new RegistroAlumnos(8036, "Armando", "Espinoza");
            RegistroAlumnos alumno37 = new RegistroAlumnos(8037, "Iber", "Delgado");
            RegistroAlumnos alumno38 = new RegistroAlumnos(8038, "Abril", "Castellanos");
            RegistroAlumnos alumno39 = new RegistroAlumnos(8039, "Max", "Luna");
            RegistroAlumnos alumno40 = new RegistroAlumnos(8040, "Marcos", "Cordoba");


            // Crear 4 grupos por carrera.
            ArmarGrupo grupo1ArtesVisuales = new ArmarGrupo();
            ArmarGrupo grupo2ArtesVisuales = new ArmarGrupo();
            ArmarGrupo grupo3ArtesVisuales = new ArmarGrupo();
            ArmarGrupo grupo4ArtesVisuales = new ArmarGrupo();
            ArmarGrupo grupo1Multimedia = new ArmarGrupo();
            ArmarGrupo grupo2Multimedia = new ArmarGrupo();
            ArmarGrupo grupo3Multimedia = new ArmarGrupo();
            ArmarGrupo grupo4Multimedia = new ArmarGrupo();


            // Agregar alumnos creados a sus respectivos grupos, siendo 5 alumnos por grupo.
            grupo1ArtesVisuales.diccionarioDeGrupo.Add(alumno1.matricula, alumno1);
            grupo1ArtesVisuales.diccionarioDeGrupo.Add(alumno2.matricula, alumno2);
            grupo1ArtesVisuales.diccionarioDeGrupo.Add(alumno3.matricula, alumno3);
            grupo1ArtesVisuales.diccionarioDeGrupo.Add(alumno4.matricula, alumno4);
            grupo1ArtesVisuales.diccionarioDeGrupo.Add(alumno5.matricula, alumno5);

            grupo2ArtesVisuales.diccionarioDeGrupo.Add(alumno6.matricula, alumno6);
            grupo2ArtesVisuales.diccionarioDeGrupo.Add(alumno7.matricula, alumno7);
            grupo2ArtesVisuales.diccionarioDeGrupo.Add(alumno8.matricula, alumno8);
            grupo2ArtesVisuales.diccionarioDeGrupo.Add(alumno9.matricula, alumno9);
            grupo2ArtesVisuales.diccionarioDeGrupo.Add(alumno10.matricula, alumno10);

            grupo3ArtesVisuales.diccionarioDeGrupo.Add(alumno11.matricula, alumno11);
            grupo3ArtesVisuales.diccionarioDeGrupo.Add(alumno12.matricula, alumno12);
            grupo3ArtesVisuales.diccionarioDeGrupo.Add(alumno13.matricula, alumno13);
            grupo3ArtesVisuales.diccionarioDeGrupo.Add(alumno14.matricula, alumno14);
            grupo3ArtesVisuales.diccionarioDeGrupo.Add(alumno15.matricula, alumno15);

            grupo4ArtesVisuales.diccionarioDeGrupo.Add(alumno16.matricula, alumno16);
            grupo4ArtesVisuales.diccionarioDeGrupo.Add(alumno17.matricula, alumno17);
            grupo4ArtesVisuales.diccionarioDeGrupo.Add(alumno18.matricula, alumno18);
            grupo4ArtesVisuales.diccionarioDeGrupo.Add(alumno19.matricula, alumno19);
            grupo4ArtesVisuales.diccionarioDeGrupo.Add(alumno20.matricula, alumno20);

            grupo1Multimedia.diccionarioDeGrupo.Add(alumno21.matricula, alumno21);
            grupo1Multimedia.diccionarioDeGrupo.Add(alumno22.matricula, alumno22);
            grupo1Multimedia.diccionarioDeGrupo.Add(alumno23.matricula, alumno23);
            grupo1Multimedia.diccionarioDeGrupo.Add(alumno24.matricula, alumno24);
            grupo1Multimedia.diccionarioDeGrupo.Add(alumno25.matricula, alumno25);

            grupo2Multimedia.diccionarioDeGrupo.Add(alumno26.matricula, alumno26);
            grupo2Multimedia.diccionarioDeGrupo.Add(alumno27.matricula, alumno27);
            grupo2Multimedia.diccionarioDeGrupo.Add(alumno28.matricula, alumno28);
            grupo2Multimedia.diccionarioDeGrupo.Add(alumno29.matricula, alumno29);
            grupo2Multimedia.diccionarioDeGrupo.Add(alumno30.matricula, alumno30);

            grupo3Multimedia.diccionarioDeGrupo.Add(alumno31.matricula, alumno31);
            grupo3Multimedia.diccionarioDeGrupo.Add(alumno32.matricula, alumno32);
            grupo3Multimedia.diccionarioDeGrupo.Add(alumno33.matricula, alumno33);
            grupo3Multimedia.diccionarioDeGrupo.Add(alumno34.matricula, alumno34);
            grupo3Multimedia.diccionarioDeGrupo.Add(alumno35.matricula, alumno35);

            grupo4Multimedia.diccionarioDeGrupo.Add(alumno36.matricula, alumno36);
            grupo4Multimedia.diccionarioDeGrupo.Add(alumno37.matricula, alumno37);
            grupo4Multimedia.diccionarioDeGrupo.Add(alumno38.matricula, alumno38);
            grupo4Multimedia.diccionarioDeGrupo.Add(alumno39.matricula, alumno39);
            grupo4Multimedia.diccionarioDeGrupo.Add(alumno40.matricula, alumno40);


            // Crear diccionarios por semestre para cada carrera.
            OrganizarPorSemestre semestre1ArtesVisuales = new OrganizarPorSemestre();
            OrganizarPorSemestre semestre2ArtesVisuales = new OrganizarPorSemestre();
            OrganizarPorSemestre semestre3ArtesVisuales = new OrganizarPorSemestre();
            OrganizarPorSemestre semestre4ArtesVisuales = new OrganizarPorSemestre();
            OrganizarPorSemestre semestre5ArtesVisuales = new OrganizarPorSemestre();
            OrganizarPorSemestre semestre6ArtesVisuales = new OrganizarPorSemestre();
            OrganizarPorSemestre semestre7ArtesVisuales = new OrganizarPorSemestre();
            OrganizarPorSemestre semestre8ArtesVisuales = new OrganizarPorSemestre();
            OrganizarPorSemestre semestre1Multimedia = new OrganizarPorSemestre();
            OrganizarPorSemestre semestre2Multimedia = new OrganizarPorSemestre();
            OrganizarPorSemestre semestre3Multimedia = new OrganizarPorSemestre();
            OrganizarPorSemestre semestre4Multimedia = new OrganizarPorSemestre();
            OrganizarPorSemestre semestre5Multimedia = new OrganizarPorSemestre();
            OrganizarPorSemestre semestre6Multimedia = new OrganizarPorSemestre();
            OrganizarPorSemestre semestre7Multimedia = new OrganizarPorSemestre();
            OrganizarPorSemestre semestre8Multimedia = new OrganizarPorSemestre();


            // Añadir los grupos a los diccionarios por semestre de cada carrera.
            semestre2ArtesVisuales.diccionarioPorSemestre.Add(Semestre.Segundo, grupo1ArtesVisuales);
            semestre4ArtesVisuales.diccionarioPorSemestre.Add(Semestre.Cuarto, grupo2ArtesVisuales);
            semestre6ArtesVisuales.diccionarioPorSemestre.Add(Semestre.Sexto, grupo3ArtesVisuales);
            semestre8ArtesVisuales.diccionarioPorSemestre.Add(Semestre.Octavo, grupo4ArtesVisuales);
            semestre2Multimedia.diccionarioPorSemestre.Add(Semestre.Segundo, grupo1Multimedia);
            semestre4Multimedia.diccionarioPorSemestre.Add(Semestre.Cuarto, grupo2Multimedia);
            semestre6Multimedia.diccionarioPorSemestre.Add(Semestre.Sexto, grupo3Multimedia);
            semestre8Multimedia.diccionarioPorSemestre.Add(Semestre.Octavo, grupo4Multimedia);


            // Crear listas de carrera.
            Carrera ArtesVisuales = new Carrera("Licenciatura en Artes Visuales");
            Carrera Multimedia = new Carrera("Ingeniería en Multimedia");
            // Agregar los diccionarios por semestre a sus respectivas listas de carrera.
            ArtesVisuales.listaDeSemestres.Add(semestre1ArtesVisuales);
            ArtesVisuales.listaDeSemestres.Add(semestre2ArtesVisuales);
            ArtesVisuales.listaDeSemestres.Add(semestre3ArtesVisuales);
            ArtesVisuales.listaDeSemestres.Add(semestre4ArtesVisuales);
            ArtesVisuales.listaDeSemestres.Add(semestre5ArtesVisuales);
            ArtesVisuales.listaDeSemestres.Add(semestre6ArtesVisuales);
            ArtesVisuales.listaDeSemestres.Add(semestre7ArtesVisuales);
            ArtesVisuales.listaDeSemestres.Add(semestre8ArtesVisuales);

            Multimedia.listaDeSemestres.Add(semestre1Multimedia);
            Multimedia.listaDeSemestres.Add(semestre2Multimedia);
            Multimedia.listaDeSemestres.Add(semestre3Multimedia);
            Multimedia.listaDeSemestres.Add(semestre4Multimedia);
            Multimedia.listaDeSemestres.Add(semestre5Multimedia);
            Multimedia.listaDeSemestres.Add(semestre6Multimedia);
            Multimedia.listaDeSemestres.Add(semestre7Multimedia);
            Multimedia.listaDeSemestres.Add(semestre8Multimedia);


            // Crear lista de institución.
            Institucion CRESP = new Institucion("Centro Regional De Estudios Superiores Palmore");
            // Agregar las listas de carrera a la lista de institución.
            CRESP.listaDeCarreras.Add(ArtesVisuales);
            CRESP.listaDeCarreras.Add(Multimedia);


            // Consultar nombre de escuela.
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Nombre de la institución: " + CRESP.nombreDeInstitucion + ".");
            Console.WriteLine("____________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("");

            // Consultar todos los alumnos.
            Console.WriteLine("____________________________________________________________________");
            Console.WriteLine("-Información general de todos los alumnos.");
            Console.WriteLine("");

            if (CRESP.listaDeCarreras[0].listaDeSemestres[0].diccionarioPorSemestre.Count == 0)
            {
                for (int i = 0; i < CRESP.listaDeCarreras.Count; i++)
                {
                    foreach (var value in CRESP.listaDeCarreras[i].listaDeSemestres[1].diccionarioPorSemestre.GetValueOrDefault(Semestre.Segundo).diccionarioDeGrupo.Values)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Matricula: " + value.matricula + " | Nombre: " + value.nombre + " | Apellido: " + value.apellido);
                    }
                    foreach (var value in CRESP.listaDeCarreras[i].listaDeSemestres[3].diccionarioPorSemestre.GetValueOrDefault(Semestre.Cuarto).diccionarioDeGrupo.Values)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Matricula: " + value.matricula + " | Nombre: " + value.nombre + " | Apellido: " + value.apellido);
                    }
                    foreach (var value in CRESP.listaDeCarreras[i].listaDeSemestres[5].diccionarioPorSemestre.GetValueOrDefault(Semestre.Sexto).diccionarioDeGrupo.Values)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Matricula: " + value.matricula + " | Nombre: " + value.nombre + " | Apellido: " + value.apellido);
                    }
                    foreach (var value in CRESP.listaDeCarreras[i].listaDeSemestres[7].diccionarioPorSemestre.GetValueOrDefault(Semestre.Octavo).diccionarioDeGrupo.Values)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Matricula: " + value.matricula + " | Nombre: " + value.nombre + " | Apellido: " + value.apellido);
                    }
                }
            }
            else
            {
                for (int i = 0; i < CRESP.listaDeCarreras.Count; i++)
                {
                    foreach (var value in CRESP.listaDeCarreras[i].listaDeSemestres[0].diccionarioPorSemestre.GetValueOrDefault(Semestre.Primer).diccionarioDeGrupo.Values)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Matricula: " + value.matricula + " | Nombre: " + value.nombre + " | Apellido: " + value.apellido);
                    }
                    foreach (var value in CRESP.listaDeCarreras[i].listaDeSemestres[2].diccionarioPorSemestre.GetValueOrDefault(Semestre.Tercero).diccionarioDeGrupo.Values)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Matricula: " + value.matricula + " | Nombre: " + value.nombre + " | Apellido: " + value.apellido);
                    }
                    foreach (var value in CRESP.listaDeCarreras[i].listaDeSemestres[4].diccionarioPorSemestre.GetValueOrDefault(Semestre.Quinto).diccionarioDeGrupo.Values)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Matricula: " + value.matricula + " | Nombre: " + value.nombre + " | Apellido: " + value.apellido);
                    }
                    foreach (var value in CRESP.listaDeCarreras[i].listaDeSemestres[6].diccionarioPorSemestre.GetValueOrDefault(Semestre.Septimo).diccionarioDeGrupo.Values)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Matricula: " + value.matricula + " | Nombre: " + value.nombre + " | Apellido: " + value.apellido);
                    }
                }
            }
            Console.WriteLine("____________________________________________________________________");


            // Consultar alumnos por matrícula.
            Console.WriteLine("");
            Console.WriteLine("____________________________________________________________________");
            Console.WriteLine("-Consultar datos del alumno con su matrícula.");

            // INSERTE LA MATRÍCULA A BUSCAR DENTRO DE ESTA VARIABLE.
            int matriculaAConsultar = 8029;
            // INSERTE LA MATRICULA A BUSCAR DENTRO DE ESTA VARIABLE.

            bool encontrado = false;

            if (CRESP.listaDeCarreras[0].listaDeSemestres[0].diccionarioPorSemestre.Count == 0)
            {
                for (int i = 0; i < CRESP.listaDeCarreras.Count; i++)
                {
                    foreach (var value in CRESP.listaDeCarreras[i].listaDeSemestres[1].diccionarioPorSemestre.GetValueOrDefault(Semestre.Segundo).diccionarioDeGrupo.Values)
                    {
                        if (encontrado == false)
                        {
                            Console.WriteLine("Buscando alumno...");
                            if (value.matricula == matriculaAConsultar)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("¡Alumno encontrado!");
                                Console.WriteLine("");
                                Console.WriteLine("Matricula: " + value.matricula + " | Nombre: " + value.nombre + " | Apellido: " + value.apellido);
                                encontrado = true;
                                break;
                            }
                        }
                    }
                    foreach (var value in CRESP.listaDeCarreras[i].listaDeSemestres[3].diccionarioPorSemestre.GetValueOrDefault(Semestre.Cuarto).diccionarioDeGrupo.Values)
                    {
                        if (encontrado == false)
                        {
                            Console.WriteLine("Buscando alumno...");
                            if (value.matricula == matriculaAConsultar)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("¡Alumno encontrado!");
                                Console.WriteLine("");
                                Console.WriteLine("Matricula: " + value.matricula + " | Nombre: " + value.nombre + " | Apellido: " + value.apellido);
                                encontrado = true;
                                break;
                            }
                        }
                    }
                    foreach (var value in CRESP.listaDeCarreras[i].listaDeSemestres[5].diccionarioPorSemestre.GetValueOrDefault(Semestre.Sexto).diccionarioDeGrupo.Values)
                    {
                        if (encontrado == false)
                        {
                            Console.WriteLine("Buscando alumno...");
                            if (value.matricula == matriculaAConsultar)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("¡Alumno encontrado!");
                                Console.WriteLine("");
                                Console.WriteLine("Matricula: " + value.matricula + " | Nombre: " + value.nombre + " | Apellido: " + value.apellido);
                                encontrado = true;
                                break;
                            }
                        }
                    }
                    foreach (var value in CRESP.listaDeCarreras[i].listaDeSemestres[7].diccionarioPorSemestre.GetValueOrDefault(Semestre.Octavo).diccionarioDeGrupo.Values)
                    {
                        if (encontrado == false)
                        {
                            Console.WriteLine("Buscando alumno...");
                            if (value.matricula == matriculaAConsultar)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("¡Alumno encontrado!");
                                Console.WriteLine("");
                                Console.WriteLine("Matricula: " + value.matricula + " | Nombre: " + value.nombre + " | Apellido: " + value.apellido);
                                encontrado = true;
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                if (encontrado == false)
                {

                    for (int i = 0; i < CRESP.listaDeCarreras.Count; i++)
                    {
                        foreach (var value in CRESP.listaDeCarreras[i].listaDeSemestres[0].diccionarioPorSemestre.GetValueOrDefault(Semestre.Primer).diccionarioDeGrupo.Values)
                        {
                            if (encontrado == false)
                            {
                                Console.WriteLine("Buscando alumno...");
                                if (value.matricula == matriculaAConsultar)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("¡Alumno encontrado!");
                                    Console.WriteLine("");
                                    Console.WriteLine("Matricula: " + value.matricula + " | Nombre: " + value.nombre + " | Apellido: " + value.apellido);
                                    encontrado = true;
                                    break;
                                }
                            }
                        }
                        foreach (var value in CRESP.listaDeCarreras[i].listaDeSemestres[2].diccionarioPorSemestre.GetValueOrDefault(Semestre.Tercero).diccionarioDeGrupo.Values)
                        {
                            if (encontrado == false)
                            {
                                Console.WriteLine("Buscando alumno...");
                                if (value.matricula == matriculaAConsultar)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("¡Alumno encontrado!");
                                    Console.WriteLine("");
                                    Console.WriteLine("Matricula: " + value.matricula + " | Nombre: " + value.nombre + " | Apellido: " + value.apellido);
                                    encontrado = true;
                                    break;
                                }
                            }
                        }
                        foreach (var value in CRESP.listaDeCarreras[i].listaDeSemestres[4].diccionarioPorSemestre.GetValueOrDefault(Semestre.Quinto).diccionarioDeGrupo.Values)
                        {
                            if (encontrado == false)
                            {
                                Console.WriteLine("Buscando alumno...");
                                if (value.matricula == matriculaAConsultar)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("¡Alumno encontrado!");
                                    Console.WriteLine("");
                                    Console.WriteLine("Matricula: " + value.matricula + " | Nombre: " + value.nombre + " | Apellido: " + value.apellido);
                                    encontrado = true;
                                    break;
                                }
                            }
                        }
                        foreach (var value in CRESP.listaDeCarreras[i].listaDeSemestres[6].diccionarioPorSemestre.GetValueOrDefault(Semestre.Septimo).diccionarioDeGrupo.Values)
                        {
                            if (encontrado == false)
                            {
                                Console.WriteLine("Buscando alumno...");
                                if (value.matricula == matriculaAConsultar)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("¡Alumno encontrado!");
                                    Console.WriteLine("");
                                    Console.WriteLine("Matricula: " + value.matricula + " | Nombre: " + value.nombre + " | Apellido: " + value.apellido);
                                    encontrado = true;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            if (encontrado == false)
            {   
                Console.WriteLine("");
                Console.WriteLine("No se encontró ningún alumno con la matrícula: " + matriculaAConsultar);    
            }

            Console.WriteLine("____________________________________________________________________");


            // Consultar la cantidad de carreras existentes en la institución.
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("____________________________________________________________________");
            Console.WriteLine("-Cantidad de carreras existentes en la institución: " + CRESP.listaDeCarreras.Count);
            Console.WriteLine("____________________________________________________________________");


            // Consultar el nombre de las carreras existentes en la institución.
            Console.WriteLine("");
            Console.WriteLine("____________________________________________________________________");
            Console.WriteLine("-Nombre de las carreras existentes en la institución:");
            for (int i = 0; i < CRESP.listaDeCarreras.Count; i++)
            {
                Console.WriteLine("");
                Console.WriteLine(CRESP.listaDeCarreras[i].nombreDeCarrera);
            }
            Console.WriteLine("____________________________________________________________________");


            // Consultar la cantidad de grupos activos en la institución.
            int conteoDeGrupos = 0;
            for (int i = 0; i < CRESP.listaDeCarreras.Count; i++)
            {
                if (CRESP.listaDeCarreras[i].listaDeSemestres[i].diccionarioPorSemestre.Count == 0)
                {
                    conteoDeGrupos = (conteoDeGrupos + CRESP.listaDeCarreras[i].listaDeSemestres.Count);
                    Console.WriteLine("");
                    Console.WriteLine("____________________________________________________________________");
                    Console.WriteLine("-Cantidad de grupos activos en la institución: " + conteoDeGrupos);
                    Console.WriteLine("____________________________________________________________________");
                }
            }
        }
    }
}
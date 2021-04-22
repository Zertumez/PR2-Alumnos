using System;
using System.Collections.Generic;

namespace PR2_Alumnos
{
    class Carrera
    {
        // Método para crear lista de carrera.
        public List<OrganizarPorSemestre> listaDeSemestres;

        public string nombreDeCarrera;

        public Carrera(string nombreDeCarrera)
        {
            listaDeSemestres = new List<OrganizarPorSemestre>();
            this.nombreDeCarrera = nombreDeCarrera;
        }

        // Método para agregar grupos separados por semestre a una lista de carrera.
        public void add(OrganizarPorSemestre registro)
        {
            listaDeSemestres.Add(registro);
        }
    }
}
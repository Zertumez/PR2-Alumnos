using System;
using System.Collections.Generic;

namespace PR2_Alumnos
{
    public enum Semestre
    {
        Primer,
        Segundo,
        Tercero,
        Cuarto,
        Quinto,
        Sexto,
        Septimo,
        Octavo
    }
    class OrganizarPorSemestre
    {
        // Método para crear diccionarios por semestre.
        public Dictionary<Semestre, ArmarGrupo> diccionarioPorSemestre;

        public OrganizarPorSemestre()
        {
            diccionarioPorSemestre = new Dictionary<Semestre, ArmarGrupo>();
        }

        // Método para añadir semestre a los grupos
        public void add(Semestre key, ArmarGrupo value)
        {
            diccionarioPorSemestre.Add(key, value);
        }
    }
}
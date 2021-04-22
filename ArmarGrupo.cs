using System;
using System.Collections.Generic;

namespace PR2_Alumnos
{
    class ArmarGrupo
    {
        // Método para crear diccionarios de grupo
        public Dictionary<int, RegistroAlumnos> diccionarioDeGrupo;

        public ArmarGrupo()
        {
            diccionarioDeGrupo = new Dictionary<int, RegistroAlumnos>();
        }

        //Método para añadir alumnnos al diccionario del grupo.
        public void add(int key, RegistroAlumnos value)
        {
            diccionarioDeGrupo.Add(key, value);
        }

    }
}
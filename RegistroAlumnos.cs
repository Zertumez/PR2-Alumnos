using System;

namespace PR2_Alumnos
{
    class RegistroAlumnos
    {
        public int matricula;
        public string nombre;
        public string apellido;

        public RegistroAlumnos(int matricula, string nombre, string apellido)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}
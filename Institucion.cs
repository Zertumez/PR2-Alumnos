using System;
using System.Collections.Generic;

namespace PR2_Alumnos
{
    class Institucion
    {
        public List<Carrera> listaDeCarreras;
        public string nombreDeInstitucion;

        public Institucion(string nombreDeInstitucion)
        {
            listaDeCarreras = new List<Carrera>();
            this.nombreDeInstitucion = nombreDeInstitucion;
        }
    }
}
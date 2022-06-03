using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenPOO_1erParcial
{
     class Estudiante
    {
        private string nombres;
        private string apellidos;
        private string institucion;
        private string cedula;

        public Estudiante(string nombres, string apellidos, string institucion, string cedula)
        {
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Institucion = institucion;
            this.Cedula = cedula;
        }

        public virtual void TipoD_estudiante(){ }
        public void ImprimirInfo()
        {
            Console.WriteLine("\n Nombres: " + nombres +
                            "\n Apellidos: " + apellidos +
                            "\n Nombre de institución: " + institucion +
                            "\n Cédula de Identidad : " + cedula);
        }


        public virtual int Calcularvalor(int valorfijoAnual, int nivelCursado, int precioFijoNivel, int cantCreditos, int precioDCredito)
        {
            int nada = 0;
            return nada;
        }










        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Institucion { get => institucion; set => institucion = value; }
        public string Cedula { get => cedula; set => cedula = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenPOO_1erParcial
{
     class EstudiUniver : Estudiante 
    {
       
        public EstudiUniver(string nombres, string apellidos, string institucion, string cedula) 
                        : base(nombres, apellidos, institucion, cedula)
        {
        }

        public override void TipoD_estudiante()
        {
            Console.WriteLine("*************Estudiante De Universidad ***************");
        }

        public override int Calcularvalor(int a, int b, int c, int cantCreditos, int precioDCredito)
        {
            return cantCreditos*precioDCredito;
        }

    }
}

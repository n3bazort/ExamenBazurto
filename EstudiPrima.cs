using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenPOO_1erParcial
{
    internal class EstudiPrima : Estudiante
    {
        public EstudiPrima(string nombres, string apellidos, string institucion, string cedula) 
                            : base(nombres, apellidos, institucion, cedula)
        {
        }

        public override void TipoD_estudiante()
        {
            Console.WriteLine("*************Estudiante De Primaria ***************");
        }
        public override int Calcularvalor(int valorfijoAnual, int b,int c, int d, int e)
        {
            return valorfijoAnual;
        }

    }
}

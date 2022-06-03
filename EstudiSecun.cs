using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenPOO_1erParcial
{
     class EstudiSecun : Estudiante
    {
        public int nivelCursado;
        public EstudiSecun(string nombres, string apellidos, string institucion, string cedula) 
                    : base(nombres, apellidos, institucion, cedula)
        {
            int aux=nivelCursado ;
        }

        public override void TipoD_estudiante()
        {
            Console.WriteLine("*************Estudiante De Secundaria ***************");
        }
        public override int Calcularvalor(int a, int aux, int precioFijoNivel, int d, int e)
        {
            return  nivelCursado*precioFijoNivel;
        }

    }
}

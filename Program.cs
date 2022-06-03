using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenPOO_1erParcial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EstudiPrima E_Pirma1 = new EstudiPrima("Dilian Josué","Bazurto García",
                                                    "Universidad Eloy Alfaro de Manabí","1325901870");
            EstudiSecun E_Secun1 = new EstudiSecun("Mateo Santiago", "Rivadeneira Cantos",
                                                    "Universidad Eloy Alfaro de Manabí", "1345901856");
            EstudiUniver E_Univer1 = new EstudiUniver("Rosa Eliana", "Afgano Santos",
                                                    "Universidad Eloy Alfaro de Manabí", "1315901833");

            /////////////////////////////////////////////////////////////////////////////////////////////////
            

            var Lista1 = new List<Estudiante>();         //Creo la lista contenedora de los objetos y sus nombres

            Lista1.Add(E_Pirma1);                           //Lo agrego a la lista
            Lista1.Add(E_Secun1);                           //Lo agrego a la lista
            Lista1.Add(E_Univer1);                          //Lo agrego a la lista

            foreach (var a in Lista1)
            {
                a.TipoD_estudiante();
                a.ImprimirInfo();
                int total=a.Calcularvalor(100, 4, 20, 8, 7); // ValorFijoAnual ** Nivel Cursado **
                                                             // Precio_Fijo_Nivel ** Cant_Creditos ** Precio_d_Créditos
                Console.WriteLine(" El valor de la matrícula anual es: $"+total+ "\n \n");
                
                Console.ReadKey();
               // Console.Clear();
            }
                Console.ReadKey();






        }


    }
}

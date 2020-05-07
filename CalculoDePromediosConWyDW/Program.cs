using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDePromediosConWyDW
{
    class Program
    {
        static void Main(string[] args)
        {
            int repetir = 1, repetirGourp = 1;
            int group, studenS;
            float nota, promedio;
            float sumaNota = 0;
            //bool studentValid;//, notaValida;

            group = PedirCanGroup();

            while (repetirGourp <= group)
            {

                {
                    studenS = PregutarEstudiantes(repetirGourp);
                    repetir = 1;
                    sumaNota = 0;
                    promedio = 0;
                    while (repetir <= studenS)
                    {
                        nota = PreguntarNotas(repetir);

                        sumaNota = sumaNota + nota;
                        repetir++;
                    }

                    promedio = sumaNota / studenS;
                    Console.WriteLine("\nEL PROMEDIO DEL SALON ES DE {0}", promedio);
                }

                repetirGourp++;

            }

            Console.ReadKey();
        }

        static int PedirCanGroup()
        {
            int grupos;

            Console.WriteLine("\nCUANTOS GRUPOS DESEA REGISTRAR");
            grupos = int.Parse(Console.ReadLine());

            while (grupos <= 0)
            {
                Console.WriteLine("ERROR DE DATOS, INTENTE DE NUEVO");
                grupos = int.Parse(Console.ReadLine());
            }

            return grupos;
        }

        static int PregutarEstudiantes(int grupo)
        {
            int studenS;
            Console.WriteLine("\nCUANTOS ALUMNOS HAY EN EL GRUPO {0}", grupo);
            studenS = int.Parse(Console.ReadLine());

            while (studenS <= 0)
            {
                Console.WriteLine("ERROR DE DATOS, INTENTE DE NUEVO");
                studenS = int.Parse(Console.ReadLine());
            }

            return studenS;
        }
        static float PreguntarNotas(int repetir)
        {
            float nota;
            Console.WriteLine("\nDIGITE NOTA DEL ESTUDIANTE {0}", repetir);
            nota = float.Parse(Console.ReadLine());

            while (nota < 0 || nota > 10)
            {
                Console.WriteLine("ERROR DE DATOS, INTENTE DE NUEVO");
                nota = float.Parse(Console.ReadLine());
            }


            return nota;
        }
    }
}

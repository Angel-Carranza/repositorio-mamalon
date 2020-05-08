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
            int repolloDeGrupo = 1, grupo, cantidadEstudiantes, repollo = 1, continuar;
            float sumaNota, nota, promedio;

            Console.Title = "CULCULADOR DE PROMEDIOS";

            do
            {
                Console.Clear();
                repolloDeGrupo = 1;
                grupo = PedirCanGrupo();

                while (repolloDeGrupo <= grupo)
                {


                    cantidadEstudiantes = PregutarEstudiantes(repolloDeGrupo);
                    repollo = 1;
                    sumaNota = 0;
                    promedio = 0;
                    while (repollo <= cantidadEstudiantes)
                    {
                        nota = PreguntarNotas(repollo);

                        sumaNota = sumaNota + nota;
                        repollo++;
                    }

                    promedio = sumaNota / cantidadEstudiantes;
                    Console.WriteLine("\nEL PROMEDIO DEL SALON ES DE {0}", promedio);


                    repolloDeGrupo++;

                }

                continuar = Preguntar();
            }
            while (continuar != 0);

            Console.Write("\nPress any key to finish . . . ");
            Console.ReadKey(true);
        }

        /// <summary>
        /// ESTE METODO SERVIRA PARA PEDIR Y VALIDAR LA CANTIDAD DE GRUPOS A REGISTRAR
        /// </summary>
        /// <returns></returns>
        static int PedirCanGrupo()
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

        /// <summary>
        /// ESTE METODO PEDIRA Y VALIDARA LA CANTIDAD DE ALUMNOS A REGISTRAR
        /// </summary>
        /// <param name="grupo"></param>
        /// <returns></returns>
        static int PregutarEstudiantes(int grupo)
        {
            int estudiantes;
            Console.WriteLine("\nCUANTOS ALUMNOS HAY EN EL GRUPO {0}", grupo);
            estudiantes = int.Parse(Console.ReadLine());

            while (estudiantes <= 0)
            {
                Console.WriteLine("ERROR DE DATOS, INTENTE DE NUEVO");
                estudiantes = int.Parse(Console.ReadLine());
            }

            return estudiantes;
        }

        /// <summary>
        /// ESTE METODO PEDIRA Y VALIDARA LA NOTA DE CADA ALUMNO A REGISTRAR
        /// </summary>
        /// <param name="numEstudi"></param>
        /// <returns></returns>
        static float PreguntarNotas(int numEstudi)
        {
            float puntuacion;
            Console.WriteLine("\nDIGITE NOTA DEL ESTUDIANTE {0}", numEstudi);
            puntuacion = float.Parse(Console.ReadLine());

            while (puntuacion < 0 || puntuacion > 10)
            {
                Console.WriteLine("ERROR DE DATOS, INTENTE DE NUEVO");
                puntuacion = float.Parse(Console.ReadLine());
            }

            return puntuacion;
        }

        /// <summary>
        /// ESTE METODO HA DE PREGUNTAR AL USUARIO SI DESEA CONTINUAR EN EL PROGRAMA
        /// </summary>
        /// <returns></returns>
        static int Preguntar()
        {
            int repetir;
            do
            {
                Console.WriteLine("\n¿DESEA INICIAR UN NUEVO PROCESO?\nPULSE 1 PARA REPETIR EL PROCESO.\nPULSE 0 PARA TERMINAR.");
                repetir = int.Parse(Console.ReadLine());
            }
            while (repetir != 1 && repetir != 0);

            return repetir;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace A_Persistencia
{
    public class P_Texto
    {
        public static int trabajarTexto(C_Entidades.E_Texto textoRecibido)
        {
            //Ahora la logica
            //var texto = textoRecibido.texto;
            var arregloTexto = TrabajandoCadena(textoRecibido.texto);

            return ContandoPalabras(arregloTexto);

            //quedo mas lindo asi ^^ 

        }
        private static string[] TrabajandoCadena(string cadenaTexto) {

            cadenaTexto = Regex.Replace(cadenaTexto, @"\s", " ");
            var texto2 = cadenaTexto.Trim();

            //queda feo asi que vamos a reemplazar esto con un metodo ^^ 
            while (texto2.Contains("  "))
            {
                texto2 = texto2.Replace("  ", " ");
            }
            string[] arregloTexto = texto2.Split(' ');

            return arregloTexto;
        }
        private static int ContandoPalabras(string [] arregloTexto) {
            int cantidad = 0;
            foreach (var palabra in arregloTexto)
            {
                cantidad++;
            }
            return cantidad;
        }
    }
}

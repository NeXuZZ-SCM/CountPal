using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_LogicaDeNegocio
{
    public class LN_Texto
    {
        //a ver un metodo que lo mande a la capa persistencia... 
        //Logica de negocio espera un objeto del tipo C_Entidades ^^ 
        //y es lo que le envio desde presentacion
        public static int EnviarObjeto(C_Entidades.E_Texto textoEntrante)
        {
            //Ahora lo mismo para persistencia de datos
            //En este caso persistencia no va a usar bases de datos
            //asi que vamos a hacer
            //que haga la logica del programa, obvio que esto
            //iria en logica pero como no usamos SQL en esta app

            return A_Persistencia.P_Texto.trabajarTexto(textoEntrante);

        }
    }
}

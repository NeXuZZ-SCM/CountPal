using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Presentacion
{
    public partial class Form1 : Form
    {

        int cantidad;
        const string mensaje = "Ingrese un monto";
        public Form1()
        {
            InitializeComponent();
            
                
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var objeto = RellenarEntidad(this.txt_CajaTexto.Text);
            //Aca estoy enviando el objeto encapsulado a logica de negocio ^^ 
            this.cantidad = B_LogicaDeNegocio.LN_Texto.EnviarObjeto(objeto);

            this.lbl_TotalPalabras.Text = this.cantidad.ToString();
        }


        #region Rellenar y Encapsular en un objeto tipo C_Entidades.E_Texto a lo que venga del textbox
        private C_Entidades.E_Texto RellenarEntidad(string textoCapturado)
        {
            var entidadTexto = new C_Entidades.E_Texto();
            entidadTexto.texto = textoCapturado;

            return entidadTexto;
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show(mensaje);
                return;
            }
            else
            {
                string precioColocado = textBox1.Text.Replace(".", ",");
                float precioXPalabra = float.Parse(precioColocado);

                float precioTotal = precioXPalabra * this.cantidad;

                label5.Text = "$" + precioTotal.ToString();
            }

        }
    }
}

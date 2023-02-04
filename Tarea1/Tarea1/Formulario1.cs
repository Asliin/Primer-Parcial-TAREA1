using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            //Variable local asignada como argumento para los párametros de las funciones a llamar.
            string numero = NumeroTextBox.Text;


            //Validación de ingreso de valores en el cuadro de texto
            if (NumeroTextBox.Text == "")
            {
                errorProvider1.SetError(NumeroTextBox, "Por Favor, ingrese un valor entero.");
                NumeroTextBox.Focus();
                return;
            }
            
            else
            {
               MessageBox.Show("El valor ingresado es un número" +DevolverParoImpar(numero).ToString() + ", además es un número " + DevolverPositivoNegativoNeutro(numero));
            }
            errorProvider1.Clear();   
        }


        //Función para determinar si el valor es par o impar
        private string DevolverParoImpar(string resultado)
        {
            int numero = Convert.ToInt32(NumeroTextBox.Text);
            int sobrante = numero % 2;

            if (sobrante ==0)
            {
                resultado= " par";
            }
            else
            {
               resultado= " impar";
            }
            return resultado;
        }

        //Función para determinar si el valor es Neutro, negativo o positivo.
        private string DevolverPositivoNegativoNeutro(string resultado)
        {
            int numero = Convert.ToInt32(NumeroTextBox.Text);
            
            if (numero ==0)
            {
                resultado= " neutro.";
            }
            else if (numero<0)
            {
                resultado = " negativo.";
            }
            else if (numero >0)
            {
               resultado= " positivo.";
            }
            return resultado;
        }
    }
}

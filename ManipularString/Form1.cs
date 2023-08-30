using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExcecutar_Click(object sender, EventArgs e)
        {
            #region Contains / ToString
            //string texto = "Este tipo de variavel é alfanumerica.";

            //if (texto.Contains("tipo"))
            //{
            //    label1.Text = "Contém.";
            //}
            //else
            //{
            //    label1.Text = "Não Contém.";
            //}

            //int num = 5400;
            //bool res = true;

            //label1.Text = res.ToString();
            #endregion

            #region ToUpper / ToLower
            //string nome = "felipe RICARDO";

            ////nome.ToUpper();

            //label1.Text = nome.ToLower();
            #endregion

            #region IndexOf / LastIndexOf
            //string nome = "Felipe Ricardo Ricardo";

            //// int indice = nome.IndexOf('a', 5, 4);
            //int indice = nome.LastIndexOf("Ricardo");

            //label1.Text = "Indice: " + indice;
            #endregion

            #region Insert / Replace
            //string nome = "Felipe Ricardo";

            ////string nomeFinal = nome.Insert(6, " João ");

            //string nomeFinal = nome.Replace("Ricardo", "Andre");

            //label1.Text = nomeFinal;
            #endregion

            #region Length / Substring
            //string nome = "Felipe Andre";

            ////int tam = nome.Length;
            ////label1.Text = "O nome " + nome + " contém " + tam + " letras.";

            //for (int i = 0; i < nome.Length; i++)
            //{
            //    label1.Text += nome[i] + "\n";
            //}

            //string parte = nome.Substring(nome.IndexOf(" "));

            //label1.Text = parte;
            #endregion

            #region Split
            //string nomes = "Leo Dani Felipe_Joao-Gui";

            //char[] separador = { ' ', '-', '_' };

            //string[] resultado = nomes.Split(separador);

            //foreach (string nome in resultado)
            //{
            //    label1.Text += nome + "\n";
            //}
            #endregion


        }
    }
}

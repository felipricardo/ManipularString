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

            string nome = "Felipe Ricardo";

            string nomeFinal = nome.Insert(0, "João ");

            label1.Text = nomeFinal;
        }
    }
}

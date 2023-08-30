using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

            #region StartsWith / EndsWith
            //string nome = "Felipe";

            ////bool res = nome.StartsWith("f", StringComparison.OrdinalIgnoreCase);
            //bool res = nome.EndsWith("iPe", StringComparison.OrdinalIgnoreCase);

            //if (res)
            //{
            //    label1.Text = "Positivo.";
            //}else
            //{
            //    label1.Text = "Negativo";
            //}
            #endregion

            #region Trim / TrimStarts / TrimEnd
            //string msg = "Salut Felipe!    ";

            ////char[] c = { ' ', '-', '_', '5' };
            ////string nova = msg.Trim(c);

            //label1.Text = ">" + msg.TrimEnd() + "<";
            #endregion

            #region Equals / CompareTo
            //string nome = "Felipe";

            //string nome2 = "Lucas";

            //if (nome.Equals(nome2, StringComparison.OrdinalIgnoreCase))
            //{
            //    label1.Text = "Positivo";
            //}else
            //{
            //    label1.Text = "Negativo";
            //}

            //label1.Text = nome.CompareTo(nome2).ToString();
            #endregion

            #region Format
            //decimal valor = 19.95m;
            //int temp = 32;

            //string s = String.Format("O valor do poduto é {0:C2} e a temperatura é {1}", valor, temp);

            //string s = String.Format("Hoje é {0:D} e são {0:T}", DateTime.Now);

            //string s = $"O valor do poduto é {valor:C2} e a temperatura é {temp}";

            //string s = $"Data: {DateTime.Now:D} e hora {DateTime.Now:T}";

            //label1.Text = s;
            #endregion

        }
    }
}

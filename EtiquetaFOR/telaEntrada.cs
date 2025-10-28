using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EtiquetaFOR.Main;

namespace EtiquetaFOR
{
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
            this.Text = AppInfo.GetTituloAplicacao();
            textBox1.Multiline = true;
            textBox1.ReadOnly = true;
            textBox1.Text = "Módulo em desenvolvimento, para utilização da instalação de drivers disponivel na aplicação utilizar senha de configuração padrão softcom tecnologia, na tela de login.";


        }
    }
}

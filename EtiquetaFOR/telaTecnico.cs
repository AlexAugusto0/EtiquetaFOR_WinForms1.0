using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtiquetaFOR
{
    public partial class telaTecnico : Form
    {
        private List<ImpressoraInfo> impressoras = new List<ImpressoraInfo>();
        public telaTecnico()
        {
            InitializeComponent();
            // 1️ Esconder os controles ao iniciar
            comboBox1.Visible = false;
            pictureBox1.Visible = false;
            linkLabel1.Visible = false;

            // 2️ Limpar valores
            comboBox1.SelectedIndex = -1;
            pictureBox1.Image = null;
            linkLabel1.Text = "";
            linkLabel1.Tag = null;
            CarregarImpressoras();
        }
        public class ImpressoraInfo
        {
            public string Nome { get; set; }
            public string ImagemPath { get; set; }  // Caminho local da imagem
            public string DriverLink { get; set; }  // URL do driver
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                checkBox2.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { 
            checkBox1.Checked = false;
            comboBox1.Visible = true;
            pictureBox1.Visible = true;
            linkLabel1.Visible = true; }
            else
            {
                // Esconder controles
                comboBox1.Visible = false;
                pictureBox1.Visible = false;
                linkLabel1.Visible = false;
            }

        }

        private void telaTecnico_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
        // Carrega impressoras predefinidas na ListView
        private void CarregarImpressoras()
        {
            // Exemplo de impressoras predefinidas
            impressoras.Add(new ImpressoraInfo
            {
                Nome = "HP LaserJet 1020",
                ImagemPath = @"C:\Users\alex.augusto\source\repos\EtiquetaFOR\EtiquetaFOR\Impressoras\Teste1.png",
                DriverLink = "https://support.hp.com/br-pt/drivers"
            });

            impressoras.Add(new ImpressoraInfo
            {
                Nome = "Epson L3150",
                ImagemPath = @"C:\Users\alex.augusto\source\repos\EtiquetaFOR\EtiquetaFOR\Impressoras\Teste2.png",
                DriverLink = "https://www.epson.com.br/drivers"
            });

            // Preenche ComboBox
            comboBox1.Items.Clear();
            foreach (var imp in impressoras)
            {
                comboBox1.Items.Add(imp.Nome);
            }

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0; // seleciona a primeira por padrão
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel1.Tag != null)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = linkLabel1.Tag.ToString(),
                    UseShellExecute = true
                });
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            string selecionada = comboBox1.SelectedItem.ToString();
            var info = impressoras.Find(i => i.Nome == selecionada);

            if (info != null)
            {
                // Exibe imagem
                if (System.IO.File.Exists(info.ImagemPath))
                    pictureBox1.Image = Image.FromFile(info.ImagemPath);
                else
                    pictureBox1.Image = null;

                // Atualiza link do driver
                linkLabel1.Text = "Download do driver";
                linkLabel1.Tag = info.DriverLink;
            }
        }
    }
}

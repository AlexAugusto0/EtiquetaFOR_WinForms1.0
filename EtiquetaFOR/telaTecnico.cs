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
    public partial class telaTecnico : Form
    {
        private List<ImpressoraInfo> impressoras = new List<ImpressoraInfo>();
        public telaTecnico()
        {
            InitializeComponent();
            // 1️ Esconder os controles ao iniciar
            comboBox1.Visible = false;
            pictureBox1.Visible = false;
            panel2.Visible = false;


            // 2️ Limpar valores
            comboBox1.SelectedIndex = -1;
            pictureBox1.Image = null;

            CarregarImpressoras();
            this.Text = AppInfo.GetTituloAplicacao();
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
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                comboBox1.Visible = true;
                pictureBox1.Visible = true;
                panel2.Visible = true;
                button1.Visible = true;
            }
            else
            {
                // Esconder controles
                comboBox1.Visible = false;
                pictureBox1.Visible = false;
                panel2.Visible = false;
                button1.Visible = false;
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
                Nome = "Elgin L42",
                ImagemPath = @"C:\Users\alex.augusto\source\repos\EtiquetaFOR\EtiquetaFOR\Impressoras\Elgin L42.jpg",
                DriverLink = "https://d2u2qhufg0q9tn.cloudfront.net/assets/arquivos/imgCard_64d36466-f8b8-4987-a297-b018497a4d81_2018-02-01_15-17-080_06667000.zip\r\n"
            });

            impressoras.Add(new ImpressoraInfo
            {
                Nome = "Elgin L42 Pro",
                ImagemPath = @"C:\Users\alex.augusto\source\repos\EtiquetaFOR\EtiquetaFOR\Impressoras\Elgin L42 Pro.jpg",
                DriverLink = "https://d2u2qhufg0q9tn.cloudfront.net/assets/arquivos/imgCard_7c0b58ab-800a-42ac-a345-4e300179d18a_ELGIN_2022.1.exe"
            });
            impressoras.Add(new ImpressoraInfo
            {
                Nome = "Elgin L42 Pro Full",
                ImagemPath = @"C:\Users\alex.augusto\source\repos\EtiquetaFOR\EtiquetaFOR\Impressoras\Elgin L42 Pro Full.jpg",
                DriverLink = "https://d2u2qhufg0q9tn.cloudfront.net/assets/arquivos/manual_32c69365-1128-4451-b2d7-dd16d4a5282b_L42PROFULL_Windows_driver.zip"
            });
            impressoras.Add(new ImpressoraInfo
            {
                Nome = "Elgin L42 DT",
                ImagemPath = @"C:\Users\alex.augusto\source\repos\EtiquetaFOR\EtiquetaFOR\Impressoras\Elgin L42 DT.jpg",
                DriverLink = "https://d2u2qhufg0q9tn.cloudfront.net/assets/arquivos/imgCard_74bc386e-2aa0-41da-bbeb-03e9183afa4c_Driver%20Windows%20L42DT_7.4.3_M-5.exe"
            });
            impressoras.Add(new ImpressoraInfo
            {
                Nome = "Argox OS-214 PLUS",
                ImagemPath = @"C:\Users\alex.augusto\source\repos\EtiquetaFOR\EtiquetaFOR\Impressoras\Argox OS-214 PLUS.jpg",
                DriverLink = "https://www.argox.com/docfile/drivers/Argox_11.5.0.exe"
            });
            impressoras.Add(new ImpressoraInfo
            {
                Nome = "Argox OS-2140",
                ImagemPath = @"C:\Users\alex.augusto\source\repos\EtiquetaFOR\EtiquetaFOR\Impressoras\Argox OS-2140.jpg",
                DriverLink = "https://www.argox.com/docfile/drivers/Argox_11.5.0.exe"
            });
            impressoras.Add(new ImpressoraInfo
            {
                Nome = "C3Tech IT200",
                ImagemPath = @"C:\Users\alex.augusto\source\repos\EtiquetaFOR\EtiquetaFOR\Impressoras\C3Tech IT200.jpg",
                DriverLink = "https://c3technology.com.br/download/DRIVES%20IT-200.rar"
            });
            impressoras.Add(new ImpressoraInfo
            {
                Nome = "Tanca TLP 300",
                ImagemPath = @"C:\Users\alex.augusto\source\repos\EtiquetaFOR\EtiquetaFOR\Impressoras\Tanca TLP 300.jpg",
                DriverLink = "https://www.tanca.com.br/assets/conteudo/drivers/TLP-300/Driver_Windows_TLP300.zip"
            });
            impressoras.Add(new ImpressoraInfo
            {
                Nome = "Zebra GC420t",
                ImagemPath = @"C:\Users\alex.augusto\source\repos\EtiquetaFOR\EtiquetaFOR\Impressoras\Zebra GC420t.jpg",
                DriverLink = "https://drive.google.com/file/d/1gBrLn5GGH0N6EwRVNUeqhE5Y03okiobA/view?usp=sharing"
            });
            impressoras.Add(new ImpressoraInfo
            {
                Nome = "Zebra TLP 2844",
                ImagemPath = @"C:\Users\alex.augusto\source\repos\EtiquetaFOR\EtiquetaFOR\Impressoras\Zebra TLP 2844.jpg",
                DriverLink = "https://drive.google.com/file/d/1gBrLn5GGH0N6EwRVNUeqhE5Y03okiobA/view?usp=sharing"
            });
            impressoras.Add(new ImpressoraInfo
            {
                Nome = "Zebra ZD220 / ZD230",
                ImagemPath = @"C:\Users\alex.augusto\source\repos\EtiquetaFOR\EtiquetaFOR\Impressoras\Zebra ZD220 ZD230.jpg",
                DriverLink = "https://drive.google.com/file/d/1325ZphEiD3ZHXuONL6grqXsZbMxlXqPL/view?usp=sharing"
            });
            impressoras.Add(new ImpressoraInfo
            {
                Nome = "Zebra ZD220 / ZD230",
                ImagemPath = @"C:\Users\alex.augusto\source\repos\EtiquetaFOR\EtiquetaFOR\Impressoras\Zebra ZD220 ZD230.jpg",
                DriverLink = "https://drive.google.com/file/d/1325ZphEiD3ZHXuONL6grqXsZbMxlXqPL/view?usp=sharing"
            });
            impressoras.Add(new ImpressoraInfo
            {
                Nome = "Coibel WKDY-80D",
                ImagemPath = @"C:\Users\alex.augusto\source\repos\EtiquetaFOR\EtiquetaFOR\Impressoras\Coibel WKDY-80D KNUP IM-604.jpg",
                DriverLink = "https://drive.google.com/file/d/1FMDWZRKpAG8EMR70Wm33Brz9vMExeFY9/view?usp=sharing"
            });
            impressoras.Add(new ImpressoraInfo
            {
                Nome = "Knup IM-604",
                ImagemPath = @"C:\Users\alex.augusto\source\repos\EtiquetaFOR\EtiquetaFOR\Impressoras\Coibel WKDY-80D KNUP IM-604.jpg",
                DriverLink = "https://drive.google.com/file/d/1FMDWZRKpAG8EMR70Wm33Brz9vMExeFY9/view?usp=sharing"
            });
            impressoras.Add(new ImpressoraInfo
            {
                Nome = "Tomate MDK 2054L",
                ImagemPath = @"C:\Users\alex.augusto\source\repos\EtiquetaFOR\EtiquetaFOR\Impressoras\Tomate MDK 2054L.jpg",
                DriverLink = "https://drive.google.com/file/d/1IE5PTPdtlMEIQmB4aTC9M2tSvfd1f2Ef/view?usp=sharing"
            });
            impressoras.Add(new ImpressoraInfo
            {
                Nome = "Tomate MDK 2054N",
                ImagemPath = @"C:\Users\alex.augusto\source\repos\EtiquetaFOR\EtiquetaFOR\Impressoras\Tomate MDK 2054N.jpg",
                DriverLink = "https://drive.google.com/file/d/1IE5PTPdtlMEIQmB4aTC9M2tSvfd1f2Ef/view?usp=sharing"
            });
            impressoras.Add(new ImpressoraInfo
            {
                Nome = "Tomate MDK 2074A",
                ImagemPath = @"C:\Users\alex.augusto\source\repos\EtiquetaFOR\EtiquetaFOR\Impressoras\Tomate MDK 2074A.jpg",
                DriverLink = "https://drive.google.com/file/d/1IE5PTPdtlMEIQmB4aTC9M2tSvfd1f2Ef/view?usp=sharing"
            });
            impressoras.Add(new ImpressoraInfo
            {
                Nome = "Tomate MDK 005",
                ImagemPath = @"C:\Users\alex.augusto\source\repos\EtiquetaFOR\EtiquetaFOR\Impressoras\Tomate MDK 005.jpg",
                DriverLink = "https://drive.google.com/file/d/1Qm-zplzJ8QJBxqnmx_0_T-2E0GZQ6u3s/view?usp=sharing"
            });
            impressoras.Add(new ImpressoraInfo
            {
                Nome = "Tomate MDK 006",
                ImagemPath = @"C:\Users\alex.augusto\source\repos\EtiquetaFOR\EtiquetaFOR\Impressoras\Tomate MDK 006.jpg",
                DriverLink = "https://drive.google.com/file/d/1aggvdhwuUAYKgcigVzY-zwUubRJ9S7ZP/view?usp=sharing"
            });
            impressoras.Add(new ImpressoraInfo
            {
                Nome = "Tomate MDK 007",
                ImagemPath = @"C:\Users\alex.augusto\source\repos\EtiquetaFOR\EtiquetaFOR\Impressoras\Tomate MDK 007.jpg",
                DriverLink = "https://drive.google.com/file/d/1Gj61G5vjCt6N9xktPWNdYTq1noEzWyYg/view?usp=sharing"
            });
            impressoras.Add(new ImpressoraInfo
            {
                Nome = "Tomate MDK 022",
                ImagemPath = @"C:\Users\alex.augusto\source\repos\EtiquetaFOR\EtiquetaFOR\Impressoras\Tomate MDK 022.jpg",
                DriverLink = "https://drive.google.com/file/d/1FMDWZRKpAG8EMR70Wm33Brz9vMExeFY9/view?usp=sharing"
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

                button1.Tag = info.DriverLink;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Tag is string url && !string.IsNullOrWhiteSpace(url))
            {
                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Não foi possível abrir o link:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

namespace EtiquetaFOR
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            configuracoes tela = new configuracoes();
            tela.ShowDialog();
        }
    }
}

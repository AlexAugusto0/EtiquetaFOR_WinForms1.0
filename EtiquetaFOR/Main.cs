namespace EtiquetaFOR
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            senhaBox.UseSystemPasswordChar = true; // Esconde caracteres
            senhaBox.KeyDown += senhaBox_KeyDown;  // Detecta tecla F11
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            configuracoes tela = new configuracoes();
            tela.ShowDialog();
        }

        private void senhaBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void senhaBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                e.SuppressKeyPress = true; // evita beep do F11

                if (senhaBox.Text == "suporte@softcom")
                {
                    // senha correta → abre a tela de configurações
                    telaTecnico tela = new telaTecnico();
                    tela.ShowDialog();
                    senhaBox.Clear(); // limpa a senha
                }
                else
                {
                    // senha incorreta → mensagem humanizada
                    MessageBox.Show(
                        "Ops! A senha digitada não confere, " +
                        "Verifique e tente novamente, por favor.",
                        "Senha incorreta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    senhaBox.Clear();       // limpa campo
                    senhaBox.Focus();       // foca de novo no TextBox
                }
            }
        }
        private void AbrirTelaConfiguracoes()
        {
            telaTecnico tela = new telaTecnico();
            tela.ShowDialog(); // abre como modal (travando a principal)
        }
    }
}

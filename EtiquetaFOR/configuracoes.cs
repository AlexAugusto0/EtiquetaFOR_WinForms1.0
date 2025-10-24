using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EtiquetaFOR
{
    public partial class configuracoes : Form
    {
        public configuracoes()
        {
            InitializeComponent();
            CarregarConfiguracao();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            textSenha.UseSystemPasswordChar = true;
        }
        private void CarregarConfiguracao()
        {
            try
            {
                string caminhoArquivo = @"C:\Users\alex.augusto\source\repos\EtiquetaFOR\EtiquetaFOR\bin\Debug\net8.0-windows\config.json";

                if (!File.Exists(caminhoArquivo))
                    return; // Nenhuma configuração existente

                string json = File.ReadAllText(caminhoArquivo);
                var config = JsonSerializer.Deserialize<ConfiguracaoBD>(json);

                if (config != null)
                {
                    textServidor.Text = config.Servidor;
                    textPorta.Text = config.Porta;
                    textUsuario.Text = config.Usuario;
                    textSenha.UseSystemPasswordChar = true;
                    textSenha.Text = config.Senha;
                    textBanco.Text = config.Banco;

                    // Mensagem discreta informando que já existe configuração
                    MessageBox.Show("💡 Uma configuração existente foi carregada automaticamente.",
                                    "Configuração Existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar configuração:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TestarConexao_Click(object sender, EventArgs e)
        {

            // Monta a connection string
            string servidor = textServidor.Text;
            string porta = textPorta.Text;
            string usuario = textUsuario.Text;
            string senha = textSenha.Text;
            string banco = textBanco.Text;

            string servidorCompleto = string.IsNullOrEmpty(porta) ? servidor : $"{servidor},{porta}";
            string connectionString =
            $"Server={servidorCompleto};Database={banco};User Id={usuario};Password={senha};TrustServerCertificate=True;";

            // Testa a conexão
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    MessageBox.Show("✅ Conexão realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Após sucesso, salva configuração
                    SalvarConfiguracao(new ConfiguracaoBD
                    {
                        Servidor = servidor,
                        Porta = porta,
                        Usuario = usuario,
                        Senha = senha,
                        Banco = banco
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"❌ Falha ao conectar:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }


        private void SalvarConfiguracao(ConfiguracaoBD config)
        {
            try
            {
                string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");

                string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(caminhoArquivo, json);

                MessageBox.Show("💾 Configuração salva com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar configuração:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Alterna entre oculto e visível
            textSenha.UseSystemPasswordChar = !textSenha.UseSystemPasswordChar;

            // Opcional: trocar ícone do olho aberto/fechado
            if (textSenha.UseSystemPasswordChar)
                btnExibirSenha.Text = "👁"; // oculto
            else
                btnExibirSenha.Text = "🙈"; // visível
        }
    }

    // Classe para representar a configuração
    public class ConfiguracaoBD
    {
    public string Servidor { get; set; }
    public string Porta { get; set; }
    public string Usuario { get; set; }
    public string Senha { get; set; }
    public string Banco { get; set; }
    }
        
}

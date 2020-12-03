using OpenQA.Selenium;
using Quicket.Rules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quicket_Suporte
{
    public partial class Menu : Form
    {
        private IWebDriver _webDriver;
        private bool _logado;
        private string _location;

        public Menu()
        {
            _location = System.Reflection.Assembly.GetEntryAssembly().Location.Replace("Quicket Suporte.dll", "");
            _webDriver = WebDriverFactory.CriarWebDriver(_location);
            InitializeComponent();
            AtribuirItens();
        }

        private void AtribuirItens()
        {
            var caminho = _location + "Cérebro.txt";

            if (!File.Exists(caminho))
                using (var stream = File.Create(caminho)) { }

            var linhas = File.ReadAllLines(caminho).ToList();

            foreach (var linha in linhas)
            {
                var props = linha.Split(";");
                if (!cbClienteId.Items.Contains(props[0]))                
                    cbClienteId.Items.Add(props[0]);
                if (!cbSenha.Items.Contains(props[1]))
                    cbSenha.Items.Add(props[1]);
                if (!cbClienteNome.Items.Contains(props[2]))
                    cbClienteNome.Items.Add(props[2]);
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbSenha.Text))            
                cbSenha.Text = "Mestre";            

            var conexao = new Quicket.Rules.Quicket().Main(cbClienteId.Text, cbSenha.Text);

            if (conexao.ConexaoIniciada)
            {
                SalvarNoArquivo(cbClienteId.Text, cbClienteNome.Text, cbSenha.Text);

                if (chkNovoTicket.Checked)                
                    new GeradorTicket(_webDriver).CarregarPagina(cbClienteNome.Text, txtAssunto.Text, ref _logado);                

                AtribuirItens();

                cbClienteId.Text = "";
                cbSenha.Text = "";
                cbClienteNome.Text = "";
                txtAssunto.Text = "";
            }
        }

        private void SalvarNoArquivo(string clienteId, string clienteNome, string conexaoSenha)
        {
            var linha = ConverterLinha(new string[] { clienteId.Replace(" ", ""), conexaoSenha, clienteNome });
            var caminho = _location + "Cérebro.txt";

            if (!File.Exists(caminho))
                using (var stream = File.Create(caminho)) { }                    

            var regExiste = false;

            var linhas = File.ReadAllLines(caminho).ToList();
            foreach (string line in linhas)
            {
                if (line.Contains(linha.Split(";")[0]))                
                    regExiste = true;    
            }

            if (!regExiste)
            {
                linhas.Add(linha);
                File.WriteAllLines(caminho, linhas);  
            }
        }

        private static string ConverterLinha(string[] textos)
        {
            for (int i = 0; i < textos.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(textos[i]))
                {
                    textos[i] = "null";
                }
            }

            return textos[0] + ";" + textos[1] + ";" + textos[2];
        }

        private void chkNovoTicket_CheckedChanged(object sender, EventArgs e)
        {
            lbNomeCliente.Visible = chkNovoTicket.Checked;
            cbClienteNome.Visible = chkNovoTicket.Checked;
            lbAssunto.Visible = chkNovoTicket.Checked;
            txtAssunto.Visible = chkNovoTicket.Checked;
        }

        private void cbClienteId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbClienteId.Text))
                return;

            var caminho = _location + "Cérebro.txt";

            var linhas = File.ReadAllLines(caminho).ToList();
            foreach (var linha in linhas)
            {
                var props = linha.Split(";");
                if (props[0] == cbClienteId.Text.Replace(" ", ""))
                {
                    if (props[1] != "null")                    
                        cbSenha.Text = props[1];

                    if(props[2] != "null")
                        cbClienteNome.Text = props[2];
                }
            }
        }
    }
}

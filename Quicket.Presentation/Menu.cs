using OpenQA.Selenium;
using Quicket.Rules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quicket.Presentation
{
    public partial class Menu : Form
    {
        private IWebDriver _webDriver;
        private bool _logado;

        public Menu()
        {
            var location = System.Reflection.Assembly.GetEntryAssembly().Location;
            _webDriver = WebDriverFactory.CriarWebDriver(location.Replace("Quicket.Presentation.dll", ""));
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Rules.Quicket.Main(txtClienteId.Text, txtSenha.Text, txtAssunto.Text, chkNovoTicket.Checked);
            new GeradorTicket(_webDriver).CarregarPagina(txtAssunto.Text, ref _logado);
        }
    }
}

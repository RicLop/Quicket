using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace Quicket.Rules
{
    public static class Quicket
    {
        public static void Main(string clienteId, string senha, string assunto, bool novoTicket)
        {
            Process TeamViewer = new Process();
            TeamViewer.StartInfo.FileName = @$"C:\Program Files (x86)\TeamViewer\Version8\TeamViewer.exe";
            TeamViewer.Start();

            TeamViewer.StartInfo.Arguments = $"--id {clienteId.Replace(" ", "")} --Password {senha}";
            TeamViewer.Start();
        }
    }
}

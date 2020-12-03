using Quicket_Suporte;
using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace Quicket.Rules
{
    public class Quicket
    {
        public ProcessDto Main(string clienteId, string senha)
        {
            Process TeamViewer = new Process();
            TeamViewer.StartInfo.FileName = $@"C:\Program Files (x86)\TeamViewer\Version8\TeamViewer.exe";
            TeamViewer.Start();

            TeamViewer.StartInfo.Arguments = $"--id {clienteId.Replace(" ", "")} --Password {senha}";
            TeamViewer.Start();

            Thread.Sleep(new TimeSpan(0, 0, 4));
            var conexao = new ProcessDto()
            {
                Process = Process.GetProcesses()
                                .Where(x => !x.MainWindowTitle.Contains("sublime", StringComparison.InvariantCultureIgnoreCase) &&
                                            x.MainWindowTitle.Contains(ExtrairId(clienteId.Replace(" ", ""))))
                                .FirstOrDefault()
            };

            if (conexao.Process != null)
                conexao.ConexaoIniciada = true;

            return conexao;
        }

        private static string ExtrairId(string clienteId)
        {
            var id = string.Empty;
            if (clienteId.Length == 9)
            {
                for (int i = 0; i < clienteId.Length; i++)
                {
                    if (i == 3 || i == 6)                    
                        id += " " + clienteId[i];                    
                    else                    
                        id += clienteId[i];                                      
                }
            }
            else
            {
                for (int i = 0; i < clienteId.Length; i++)
                {
                    if (i == 1 || i == 3 || i == 6)                    
                        id += " " + clienteId[i];                    
                    else                    
                        id += clienteId[i];                    
                }
            }

            return id;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicket_Suporte
{
    public class ProcessDto
    {
        public Process Process { get; set; }
        public bool ConexaoIniciada { get; set; } = false;
        public bool ConexaoEncerrada { get; set; } = false;
    }
}

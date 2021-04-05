using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeLabs.Codelab05
{
    interface ICircuit
    {
        ILamp device { get; set; }
        public void Toggle();

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeLabs.Codelab02
{
    interface ISlotCategory
    {
        public bool isFree { get; set; }
        public int resourceId { get; set; }
        public void MarkFree();
        public void MarkBusy();


    }
}

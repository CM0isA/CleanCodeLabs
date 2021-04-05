using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeLabs.Codelab02
{
    class SpaceSlot : ISlotCategory
    {
        public bool isFree { get; set; }
        public int resourceId { get; set; }

        public SpaceSlot()
        {
            resourceId = new Random().Next() * 100;
        }

        public void MarkBusy()
        {
            Console.WriteLine("Space slot Marked as busy for resourceId = " + resourceId);
        }

        public void MarkFree()
        {
            Console.WriteLine("Space slot Marked as free for resourceId = " + resourceId);
        }
    }
}

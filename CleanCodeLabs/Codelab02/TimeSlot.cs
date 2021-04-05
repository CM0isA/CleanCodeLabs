using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeLabs.Codelab02
{
    class TimeSlot : ISlotCategory
    {
        public bool isFree { get; set; }
        public int resourceId { get; set; }

        public TimeSlot()
        {
            resourceId = new Random().Next() * 50;
        }

        public void MarkBusy()
        {
            Console.WriteLine("Time slot Marked as busy for resourceId = " + resourceId);
        }

        public void MarkFree()
        {
            Console.WriteLine("Time slot Marked as free for resourceId = " + resourceId);
        }
    }
}

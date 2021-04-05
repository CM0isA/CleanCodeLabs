using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeLabs.Codelab02
{
    class SlotCategoryFactory
    {
        public static ISlotCategory GetSlotCategory(ResourceAllocator.SlotCategory slotCategory)
        {
            switch (slotCategory)
            {
                case ResourceAllocator.SlotCategory.TimeSlot:
                    return new TimeSlot();

                case ResourceAllocator.SlotCategory.SpaceSlot:
                    return new SpaceSlot();
                default:
                    return null;
            }
        }

    }
}

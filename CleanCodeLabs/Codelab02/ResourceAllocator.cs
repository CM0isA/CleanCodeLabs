using System;

namespace CleanCodeLabs.Codelab02
{
    public class ResourceAllocator 
    {
        public enum SlotCategory
        {
            TimeSlot,
            SpaceSlot
        }



        ISlotCategory slotCategory;

        public int Allocate(SlotCategory slotCategory)
        {
            this.slotCategory = SlotCategoryFactory.GetSlotCategory(slotCategory);
            int resourceId = this.slotCategory.resourceId;
            this.slotCategory.MarkBusy();
            return resourceId;

        }

        public void Deallocate(SlotCategory slotCategory, int resourceId)
        {
            this.slotCategory = SlotCategoryFactory.GetSlotCategory(slotCategory);
            this.slotCategory.resourceId = resourceId;
            this.slotCategory.MarkFree();
        }

        //private void MarkSpaceSlotFree(int resourceId)
        //{
        //    Console.WriteLine("Space slot Marked as free for resourceId = " + resourceId);
        //}

        //private void MarkTimeSlotFree(int resourceId)
        //{
        //    Console.WriteLine("Time slot Marked as free for resourceId = " + resourceId);
        //}

        //private void MarkSpaceSlotBusy(int resourceId)
        //{
        //    Console.WriteLine("Space slot Marked as busy for resourceId = " + resourceId);
        //}

        //private int FindFreeSpaceSlot()
        //{
        //    return new Random().Next() * 100;
        //}

        //private void MarkTimeSlotBusy(int resourceId)
        //{
        //    Console.WriteLine("Time slot Marked as busy for resourceId = " + resourceId);
        //}

        //private int FindFreeTimeSlot()
        //{
        //    return new Random().Next() * 50;
        //}
    }
}
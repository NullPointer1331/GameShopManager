using System;

public class CombinedObject
{
	public CombinedObject()
	{
        /// <summary>
        /// The item object
        /// </summary>
        public ItemObject item { get; set; }

        /// <summary>
        /// The quantity of said item object
        /// </summary>
        public int quantity { get; set; }


        public CombinedObject(ItemObject item, UserObject.InventoryItem quant)
        {
            item = item;
            quantity = quant.quantity;
        }
    }
}

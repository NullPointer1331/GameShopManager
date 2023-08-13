using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopManager
{
    /// <summary>
    /// The InventoryItem and ItemObject combined into one object
    /// </summary>
	internal class CombinedObject
	{
        /// <summary>
        /// The item object
        /// </summary>
        public ItemObject Item { get; set; }

        /// <summary>
        /// The quantity of said item object
        /// </summary>
        public int Quantity { get; set; }


        public CombinedObject(ItemObject item, UserObject.InventoryItem quant)
        {
            Item = item;
            Quantity = quant.Quantity;
        }
    }
}

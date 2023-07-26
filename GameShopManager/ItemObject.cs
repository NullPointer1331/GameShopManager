using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopManager
{
    internal class ItemObject
    {
        /// <summary>
        /// Refrence ID for database
        /// </summary>
        public int ItemID { get; set; }
        
        /// <summary>
        /// Display name for user interface
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// Displayed description for item
        /// </summary>
        public string ItemDescription { get; set; }

        /// <summary>
        /// Current price for item
        /// </summary>
        public int ItemPrice { get; set; }

        /// <summary>
        /// Amount of item stored
        /// </summary>
        public int Quantity { get; set; }
    }
}

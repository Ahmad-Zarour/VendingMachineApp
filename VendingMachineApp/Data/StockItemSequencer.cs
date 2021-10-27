using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp.Data
{
    public static class StockItemSequencer
    {
         static int _itemId;

        public static int NextStockItemId()
        {
            return ++_itemId;
        }
    }
}

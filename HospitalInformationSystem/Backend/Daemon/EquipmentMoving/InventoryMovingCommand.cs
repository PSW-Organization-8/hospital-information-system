using SIMS.Repositories.SecretaryRepo;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Windows;
using SIMS.Model;
using SIMS.Repositories.RoomInventoryRepo;
using SIMS.Service;

namespace SIMS.Daemon.PremestajOpreme
{
    public class InventoryMovingCommand
    {
        private RoomInventoryService roomInventoryController = new RoomInventoryService();

        public DateTime DateTime { get; set; }
        public string SourceRoomNumber { get; set; }
        public string DestinationRoomNumber { get; set; }
        public string InventoryID { get; set; }
        public int Amount { get; set; }
        public InventoryMovingCommand(DateTime dateTime, string sourceRoomNumber, string destinationRoomNumber, string inventoryID, int amount)
        {
            DateTime = dateTime;
            this.SourceRoomNumber = sourceRoomNumber;
            this.DestinationRoomNumber = destinationRoomNumber;
            this.InventoryID = inventoryID;
            this.Amount = amount;
        }

        public void Execute()
        {
            if (roomInventoryController.MoveInventory(SourceRoomNumber, DestinationRoomNumber, InventoryID, Amount))
            {
                //logic used in wpf-this shows message about success of operation
                //MessageBox.Show(Amount.ToString() + " opreme " + InventoryID + " premešteno iz prostorije " + SourceRoomNumber + " u prostoriju " + DestinationRoomNumber + ".");
            }
        }
    }
}

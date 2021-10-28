﻿using System;
using System.Collections.Generic;
using System.Text;
using SIMS.Repositories.InventoryMovingCommandRepo;
using SIMS.Repositories.SecretaryRepo;
using SIMS.Service;

namespace SIMS.Daemon.PremestajOpreme
{
    public class InventoryMovingQueue
    {
        private InventoryMovingCommandService inventoryMovingCommandController = new InventoryMovingCommandService();

        private static InventoryMovingQueue _instance = new InventoryMovingQueue();
        public static InventoryMovingQueue Instance
        {
            get
            {
                return _instance;
            }
        }

        public void PushCommand(InventoryMovingCommand command)
        {
            inventoryMovingCommandController.CreateOrUpdate(command);
        }

        public void Consistify()
        {
            foreach (var command in inventoryMovingCommandController.ReadAll())
            {
                if (command.DateTime <= DateTime.Now)
                {
                    inventoryMovingCommandController.Delete(command);
                    command.Execute();
                }
            }
        }
    }
}





using HospitalClassLib.RoomsAndEquipment.Model;
using HospitalClassLib.RoomsAndEquipment.RoomInventoryRepo;
using SIMS.Repositories;

namespace HospitalClassLib.RoomsAndEquipment.InventoryRepo
{
    public class InventoryFileRepository : GenericFileRepository<string, Inventory, InventoryFileRepository>,IInventoryRepository
    {
        protected override string getPath()
        {
            return @".\..\..\..\Data\oprema.json";
        }
        protected override string getKey(Inventory dinamickaOprema)
        {
            return dinamickaOprema.ID;
        }

        protected override void RemoveReferences(string key)
        {
            
        }

        protected override void ShouldSerialize(Inventory entity)
        {
            //ne treba logika za serijalizaciju
        }
    }
}

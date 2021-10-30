
using HospitalClassLib.RoomsAndEquipment.Model;
using HospitalClassLib.RoomsAndEquipment.RoomInventoryRepo;
using HospitalClassLib.Schedule.Model;
using HospitalClassLib.Schedule.Repository.AppointmentRepo;
using HospitalClassLib.SharedModel.Enums;
using SIMS.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;



namespace HospitalClassLib.RoomsAndEquipment.RoomRepo
{
    public class RoomFileRepository : GenericFileRepository<string, Room, RoomFileRepository>,IRoomRepository
    {
        protected override string getPath()
        {
            return @".\..\..\..\Data\prostorije.json";
        } 

        protected override string getKey(Room entity)
        {
            return entity.Number;
        }

        protected override void RemoveReferences(string key)
        {
            
        }

        public List<Room> UcitajProstorijeZaPreglede()
        {
            List<Room> prostorije = GetAll();
            for (int i = 0; i < prostorije.Count; i++)
            {
                if (prostorije[i].RoomType != RoomType.eximantionRoom || prostorije[i].Available==false)
                {
                    prostorije.RemoveAt(i);
                    i--;
                }
            }
            return prostorije;
        }

        protected override void ShouldSerialize(Room entity)
        {
        }
    }
}
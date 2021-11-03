using IntegrationClassLib.Parthership.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationClassLib.Parthership.Service
{

    public class ObjectionService
    {

        ObservableCollection<Objection> objections = new ObservableCollection<Objection>();
        private static ObjectionService instance = null;

        public static ObjectionService GetInstance()
        {
            if (instance == null)
            {
                instance = new ObjectionService();
            }
            return instance;
        }

        public Objection Add(Objection objection)
        {
            objection.Id = (objections.Count + 1).ToString();
            objections.Add(objection);
            return objection;
        }

        public ObservableCollection<Objection> GetAll()
        {
            return objections;
        }

    }
}

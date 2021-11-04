
using IntegrationClassLib.Pharmacy.Model;
using SIMS.Repositories;
using System;
using System.Collections.Generic;

using System.Text;

namespace IntegrationClassLib.Pharmacy.Repository.AllergenRepo
{
    class ComponentFileRepository : GenericFileRepository<string, Component, ComponentFileRepository>,IComponentRepository
    {
        public Component Create(Component t)
        {
            throw new NotImplementedException();
        }

        public bool ExistsById(string id)
        {
            throw new NotImplementedException();
        }

        public Component Get(string id)
        {
            throw new NotImplementedException();
        }

        protected override string getKey(Component entity)
        {
            return entity.ID;
        }

        protected override string getPath()
        {
            return @".\..\..\..\Data\alergeni.json";
        }

        protected override void RemoveReferences(string key)
        {
        }

        protected override void ShouldSerialize(Component entity)
        {
            
        }

        bool IGenericRepository<Component, string>.Delete(string id)
        {
            throw new NotImplementedException();
        }

        Component IGenericRepository<Component, string>.Update(Component t)
        {
            throw new NotImplementedException();
        }
    }
}

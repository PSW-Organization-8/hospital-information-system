using PharmacyClassLib.Model;
using PharmacyClassLib.Repository.MedicationIngredientRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyClassLib.Repository.MedicationIngredientsRepository
{
    public class MedicationIngredientRepository : AbstractSqlRepository<MedicationIngredient, long>, IMedicationIngredientRepository
    {
        public MedicationIngredientRepository(MyDbContext dbContext) : base(dbContext)
        {

        }

        protected override long GetId(MedicationIngredient entity)
        {
            return entity.Id;
        }
    }
}

using PharmacyClassLib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyClassLib.Repository.IngredientQuantityRepository
{
    public class IngredientQuantityRepository : AbstractSqlRepository<IngredientQuantity, long>, IIngredientQuantityRepository
    {
        public IngredientQuantityRepository(MyDbContext dbContext) : base(dbContext)
        {

        }

        protected override long GetId(IngredientQuantity entity)
        {
            return entity.Id;
        }
    }
}

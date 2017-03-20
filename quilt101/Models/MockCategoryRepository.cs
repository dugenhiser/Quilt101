using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quilt101.Model
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Catergory> Categories
        {
            get
            {
                return new List<Catergory>
                {
                    new Catergory{CategoryId=1, CaegoryName="Numba one", Desription="Double Striped Colors" },
                    new Catergory{CategoryId=1, CaegoryName="Numba two", Desription="Double Striped Colors" },
                    new Catergory{CategoryId=1, CaegoryName="Numba Three", Desription="Double Striped Colors" }

                };

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quilt101.Model
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryId=1, CategoryName="Numba one", Desription="Double Striped Colors" },
                    new Category{CategoryId=1, CategoryName="Numba two", Desription="Double Striped Colors" },
                    new Category{CategoryId=1, CategoryName="Numba Three", Desription="Double Striped Colors" }

                };

            }
        }
    }
}

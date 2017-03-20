using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quilt101.Model
{
    public class MockQuiltRepository: IQuiltRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Quilt> Quilts
        {
            get
            {
                return new List<Quilt>
                {
                    new Quilt {QuiltId = 1, Name = "Falling In Love", Price=120, ShortDescription="It's a Leaf", ImageUrl="../images/fallingInLove.jpg"},
                    new Quilt {QuiltId = 2, Name = "Sweet Strawberry", Price=130, ShortDescription="In the Mornin, I'm makin waffles", ImageUrl="../images/sweetStrawberry.jpg"},
                    new Quilt {QuiltId = 3, Name = "Lifes A Breeze", Price=160, ShortDescription="Baby Blanket" , ImageUrl="../images/lifesABreeze.jpg"},
                    new Quilt {QuiltId = 4, Name = "Double Stripe", Price=140, ShortDescription="Pinkish Stripes", ImageUrl="../images/FullSizeR.jpg"},
                    new Quilt {QuiltId = 5, Name = "Blues", Price=150, ShortDescription="Or maybe Turqoise" , ImageUrl="../images/IMG_3584.jpg"},
                    new Quilt {QuiltId = 6, Name = "Modern Patchwork", Price=155, ShortDescription="Hodge Podge" , ImageUrl="../images/modernUnisexPatchwork.jpg"},
                    new Quilt {QuiltId = 7, Name = "Starry Starry Midnight", Price=165, ShortDescription="Sleep Tight" , ImageUrl="../images/starryStarryMidnight.jpg"},
                    new Quilt {QuiltId = 8, Name = "Panda", Price=170, ShortDescription="They just eat, sleep and play, just like a real cuddly giant baby" , ImageUrl="../images/panda.jpg" }
                };
            }
        }

        public Quilt GetQuiltById(int quiltId)
        {
            throw new NotImplementedException();
        }
    }
}


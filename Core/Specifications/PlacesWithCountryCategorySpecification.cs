using Core.Entities;

namespace Core.Specifications
{
    public class PlacesWithCountryCategorySpecification : SpecificationBase<Place>
    {
        public PlacesWithCountryCategorySpecification()
        {
            AddInclude(x => x.Country);
            AddInclude(x => x.Category);
        }

        public PlacesWithCountryCategorySpecification(int id) : base(x => x.IdPlace == id)
        {
            AddInclude(x => x.Country);
            AddInclude(x => x.Category);
        }
    }
}

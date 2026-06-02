using project_pkdsim.Generics.Parents.Gender.Type;

namespace project_pkdsim.Generics.Parents.Type.Gender.Mom
{
    public class Mom
    {
        private ParentsGenderType parentType = ParentsGenderType.Female;
        public ParentsGenderType GetGenderType()
        {
            return parentType;
        }
    }
}
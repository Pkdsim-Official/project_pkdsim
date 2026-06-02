using project_pkdsim.Generics.Parents.Gender.Type;

namespace project_pkdsim.Generics.Parents.Type.Gender.Dad
{
    public class Dad
    {
        private ParentsGenderType parentType = ParentsGenderType.Male;
        public ParentsGenderType GetGenderType()
        {
            return parentType;
        }
    }
}
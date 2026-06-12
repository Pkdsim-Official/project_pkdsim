using project_pkdsim.Generics.ANIMATOR.Type.Model.Type.Base;
using project_pkdsim.Generics.ANIMATOR.Type.Model.Type.Species.Type;
using project_pkdsim.Generics.ANIMATOR.Type.Model.Type.Gender.Type;
using project_pkdsim.Generics.ANIMATOR.Type.Model.Type.Base.Type;
namespace project_pkdsim.Generics.ANIMATOR.Type.Model.Parent
{
    public interface IParentModelAnimator
    {
        public abstract AnimatorModelType animatorModelType { get; }
        public abstract ParentAnimatorSpeciesType animatorModelDadSpecies { get; }
        public abstract ParentAnimatorSpeciesType animatorModelMomSpecies { get; }
        public abstract ParentAnimatorGenderType animatorDadModelGender { get; }
        public abstract ParentAnimatorGenderType animatorMomModelGender { get; }  
    }
    public class AbsolAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;

        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;
    }
    public class BeedrillAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;

        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;
    }
    public class BlazikenAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;

        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;
    }
    public class BraixenAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;

        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;
    }
    public class CinderaceAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;

        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;
    }
    public class DelphoxAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;

        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;
    }
        public class DragapultAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;

        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;
    }
    public class EspeonAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;

        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;
    }
    public class FlareonAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;
        
        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;
    }
    public class FrostlassAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;

        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;
    }
    public class GarchompAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;

        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;
    }
    public class GardeviorAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;

        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;
    }
    public class GlaceonAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;

        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;
    }
    public class HattereneAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;

        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;

    }
    public class JolteonAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;

        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;

    }
    public class LeafeonAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;

        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;

    }
    public class LopunnyAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;

        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;
        
    }
    public class LucarioAnimator : IParentModelAnimator
    {
         public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;

        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;

    }
    public class LunalaAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;

        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;
    }
    public class MeowscaradaAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;

        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;
        
    }
    public class NoivernAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;

        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;
        
    }
    public class PheromosaAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;

        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;

    }
    public class PrimarinaAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;

        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;

    }
    public class SalazzleAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;

        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;

    }
    public class SylveonAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;

    }
    public class TsareenaAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;

    }
    public class UmbreonAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;

        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;

    }
    public class VaporeonAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;

        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;

    }
    public class VespiquenAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;

    }
    public class ZoroarkAnimator : IParentModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.Parent;
        
        public ParentAnimatorSpeciesType animatorModelDadSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorSpeciesType animatorModelMomSpecies => ParentAnimatorSpeciesType.;
        public ParentAnimatorGenderType animatorDadModelGender => ParentAnimatorGenderType.MALE;
        public ParentAnimatorGenderType animatorMomModelGender => ParentAnimatorGenderType.FEMALE;
    }
}
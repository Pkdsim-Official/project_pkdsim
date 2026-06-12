using project_pkdsim.Generics.ANIMATOR.Type.Model.Type.Base;
using project_pkdsim.Generics.ANIMATOR.Type.Model.Type.Species.Type;
using project_pkdsim.Generics.ANIMATOR.Type.Model.Type.Gender.Type;
using project_pkdsim.Generics.ANIMATOR.Type.Model.Type.Base.Type;

namespace project_pkdsim.Generics.ANIMATOR.Type.Model.Npc
{
    public interface INpcModelAnimator
    {
        public abstract AnimatorModelType animatorModelType { get; }
        public abstract NpcAnimatorSpeciesType animatorModelSpecies { get; }
        public abstract NpcAnimatorGenderType animatorModelGender { get; }  
    }
    public class AbsolAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.ABSOL;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;
    }

    public class BeedrillAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.BEEDRILL;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;
    }

    public class BlazikenAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.BLAZIKEN;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;
    }

    public class BraixenAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.BRAIXEN;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;
    }

    public class CinderaceAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.CINDERACE;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;
    }

    public class DelphoxAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.DELPHOX;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;
    }

        public class DragapultAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.DRAGAPULT;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;
    }
    public class EspeonAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.ESPEON;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;
    }

    public class FlareonAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.FLAREON;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;
    }

    public class FrostlassAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.FROSTLASS;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;
    }

    public class GarchompAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.GARCHOMP;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;
    }

    public class GardeviorAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.GARDEVOIR;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;
    }

    public class GlaceonAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.GLACEON;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;
    }
    public class HattereneAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.HATTERENE;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;

    }
    public class JolteonAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.JOLTEON;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;

    }
    public class LeafeonAnimator : INpcModelAnimator
    {

        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.LEAFEON;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;



    }
    public class LopunnyAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.LOPUNNY;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;

        
    }
    public class LucarioAnimator : INpcModelAnimator
    {
         public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.LUCARIO;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;

    }
    public class LunalaAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.LUNALA;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;


    }
    public class MeowscaradaAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.MEOWSCARADA;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;
        
    }
    public class NoivernAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.NOIVERN;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;
        
    }
    public class PheromosaAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.PHEROMOSA;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;

    }
    public class PrimarinaAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.PRIMARINA;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;

    }
    public class SalazzleAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.SALAZZLE;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;

    }
    public class SylveonAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.SYLVEON;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;

    }
    public class TsareenaAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.TSAREENA;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;

    }
    public class UmbreonAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.UMBREON;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;

    }
    public class VaporeonAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.VAPOREON;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;

    }
    public class VespiquenAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.VESPIQUEN;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;

    }
    public class ZoroarkAnimator : INpcModelAnimator
    {
        public AnimatorModelType animatorModelType => AnimatorModelType.NPC;

        public NpcAnimatorSpeciesType animatorModelSpecies => NpcAnimatorSpeciesType.ZOROARK;

        public NpcAnimatorGenderType animatorModelGender => NpcAnimatorGenderType.FEMALE;

    }
}
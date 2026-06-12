using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark;
using UnityEngine;


namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents
{
    public class AnimatorParents_LoadFailSafe
    {
        private LFS_EspeonParentsFailSafe LFS_EspeonParentsFailSafeAnimator;
        private LFS_FlareonParentsFailSafe LFS_FlareonParentsFailSafeAnimator;
        private LFS_GlaceonParentsFailSafe LFS_GlaceonParentsFailSafeAnimator;
        private LFS_JolteonParentsFailSafe LFS_JolteonParentsFailSafeAnimator;
        private LFS_LeafeonParentsFailSafe LFS_LeafeonParentsFailSafeAnimator;
        private LFS_SylveonParentsFailSafe LFS_SylveonParentsFailSafeAnimator;
        private LFS_UmbreonParentsFailSafe LFS_UmbreonParentsFailSafeAnimator;
        private LFS_VaporeonParentsFailSafe LFS_VaporeonParentsFailSafeAnimator;
        private LFS_NoivernParentsFailSafe LFS_NoivernParentsFailSafeAnimator;
        private LFS_AbsolParentsFailSafe LFS_AbsolParentsFailSafeAnimator;
        private LFS_BeedrillParentsFailSafe LFS_BeedrillParentsFailSafeAnimator;
        private LFS_BraixenParentsFailSafe LFS_BraixenParentsFailSafeAnimator;
        private LFS_CinderaceParentsFailSafe LFS_CinderaceParentsFailSafeAnimator;
        private LFS_DelphoxParentsFailSafe LFS_DelphoxParentsFailSafeAnimator;
        private LFS_DragapultParentsFailSafe LFS_DragapultParentsFailSafeAnimator;
        private LFS_FrostlassParentsFailSafe LFS_FrostlassParentsFailSafeAnimator;
        private LFS_GarchompParentsFailSafe LFS_GarchompParentsFailSafeAnimator;
        private LFS_HattereneParentsFailSafe LFS_HattereneParentsFailSafeAnimator;
        private LFS_LopunnyParentsFailSafe LFS_LopunnyParentsFailSafeAnimator;
        private LFS_LucarioParentsFailSafe LFS_LucarioParentsFailSafeAnimator;
        private LFS_LunalaParentsFailSafe LFS_LunalaParentsFailSafeAnimator;
        private LFS_MeowscaradaParentsFailSafe LFS_MeowscaradaParentsFailSafeAnimator;
        private LFS_PheromosaParentsFailSafe LFS_PheromosaParentsFailSafeAnimator;
        private LFS_PrimarinaParentsFailSafe LFS_PrimarinaParentsFailSafeAnimator;
        private LFS_ZoroarkParentsFailSafe LFS_ZoroarkParentsFailSafeAnimator;

        public void FailSafe()
        {
            Debug.Log("Animator is Loading FailSafe");
            LoadFailSafeParents();
        }
        private void LoadFailSafeParents()
        {
            LeafeonParentsFailSafeAnimator();
            GlaceonParentsFailSafeAnimator();
            JolteonParentsFailSafeAnimator();
            EspeonParentsFailSafeAnimator();
            SylveonParentsFailSafeAnimator();
            VaporeonParentsFailSafeAnimator();
            UmbreonParentsFailSafeAnimator();
            FlareonParentsFailSafeAnimator();
            NoivernParentsFailSafeAnimator();
            AbsolParentsFailSafeAnimator();
            BeedrillParentsFailSafeAnimator();
            BraixenParentsFailSafeAnimator();
            CinderaceParentsFailSafeAnimator();
            DelphoxParentsFailSafeAnimator();
            DragapultParentsFailSafeAnimator();
            FrostlassParentsFailSafeAnimator();
            GarchompParentsFailSafeAnimator();
            HattereneParentsFailSafeAnimator();
            LopunnyParentsFailSafeAnimator();
            LucarioParentsFailSafeAnimator();
            LunalaParentsFailSafeAnimator();
            MeowscaradaParentsFailSafeAnimator();
            PheromosaParentsFailSafeAnimator();
            PrimarinaParentsFailSafeAnimator();
            ZoroarkParentsFailSafeAnimator();
        }
        private void LeafeonParentsFailSafeAnimator()
        {
            LFS_LeafeonParentsFailSafeAnimator.LoadFailSafeLeafeonParents_AnimatorController();
        }
        private void GlaceonParentsFailSafeAnimator()
        {
            LFS_GlaceonParentsFailSafeAnimator.LoadFailSafeGlaceonParents_AnimatorController();
        }
        private void JolteonParentsFailSafeAnimator()
        {
            LFS_JolteonParentsFailSafeAnimator.LoadFailSafeJolteonParents_AnimatorController();
        }
        private void EspeonParentsFailSafeAnimator()
        {
            LFS_EspeonParentsFailSafeAnimator.LoadFailSafeEspeonParents_AnimatorController();
        }
        private void SylveonParentsFailSafeAnimator()
        {
            LFS_SylveonParentsFailSafeAnimator.LoadFailSafeSylveonParents_AnimatorController();
        }
        private void VaporeonParentsFailSafeAnimator()
        {
            LFS_VaporeonParentsFailSafeAnimator.LoadFailSafeVaporeonParents_AnimatorController();
        }
        private void UmbreonParentsFailSafeAnimator()
        {
            LFS_UmbreonParentsFailSafeAnimator.LoadFailSafeUmbreonParents_AnimatorController();
        }
        private void FlareonParentsFailSafeAnimator()
        {
            LFS_FlareonParentsFailSafeAnimator.LoadFailSafeFlareonParents_AnimatorController();
        }
        private void NoivernParentsFailSafeAnimator()
        {
            LFS_NoivernParentsFailSafeAnimator.LoadFailSafeNoivernParents_AnimatorController();
        }
        private void AbsolParentsFailSafeAnimator()
        {
            LFS_AbsolParentsFailSafeAnimator.LoadFailSafeAbsolParents_AnimatorController();
        }
        private void BeedrillParentsFailSafeAnimator()
        {
            LFS_BeedrillParentsFailSafeAnimator.LoadFailSafeBeedrillParents_AnimatorController();
        }
        private void BraixenParentsFailSafeAnimator()
        {
            LFS_BraixenParentsFailSafeAnimator.LoadFailSafeBraixenParents_AnimatorController();
        }
        private void CinderaceParentsFailSafeAnimator()
        {
            LFS_CinderaceParentsFailSafeAnimator.LoadFailSafeCinderaceParents_AnimatorController();
        }
        private void DelphoxParentsFailSafeAnimator()
        {
            LFS_DelphoxParentsFailSafeAnimator.LoadFailSafeDelphoxParents_AnimatorController();
        }
        private void DragapultParentsFailSafeAnimator()
        {
            LFS_DragapultParentsFailSafeAnimator.LoadFailSafeDragapultParents_AnimatorController();
        }
        private void FrostlassParentsFailSafeAnimator()
        {
            LFS_FrostlassParentsFailSafeAnimator.LoadFailSafeFrostlassParents_AnimatorController();
        }
        private void GarchompParentsFailSafeAnimator()
        {
            LFS_GarchompParentsFailSafeAnimator.LoadFailSafeGarchompParents_AnimatorController();
        }
        private void HattereneParentsFailSafeAnimator()
        {
            LFS_HattereneParentsFailSafeAnimator.LoadFailSafeHattereneParents_AnimatorController();
        }
        private void LopunnyParentsFailSafeAnimator()
        {
            LFS_LopunnyParentsFailSafeAnimator.LoadFailSafeLopunnyParents_AnimatorController();
        }
        private void LucarioParentsFailSafeAnimator()
        {
            LFS_LucarioParentsFailSafeAnimator.LoadFailSafeLucarioParents_AnimatorController();
        }
        private void LunalaParentsFailSafeAnimator()
        {
            LFS_LunalaParentsFailSafeAnimator.LoadFailSafeLunalaParents_AnimatorController();
        }
        private void MeowscaradaParentsFailSafeAnimator()
        {
            LFS_MeowscaradaParentsFailSafeAnimator.LoadFailSafeMeowscaradaParents_AnimatorController();
        }
        private void PheromosaParentsFailSafeAnimator()
        {
            LFS_PheromosaParentsFailSafeAnimator.LoadFailSafePheromosaParents_AnimatorController();
        }
        private void PrimarinaParentsFailSafeAnimator()
        {
            LFS_PrimarinaParentsFailSafeAnimator.LoadFailSafePrimarinaParents_AnimatorController();
        }
        private void ZoroarkParentsFailSafeAnimator()
        {
            LFS_ZoroarkParentsFailSafeAnimator.LoadFailSafeZoroarkParents_AnimatorController();
        }
    }
}
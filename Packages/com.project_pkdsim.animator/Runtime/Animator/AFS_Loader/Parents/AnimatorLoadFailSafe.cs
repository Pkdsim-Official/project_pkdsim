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


namespace project_pkdsim.ANIMATOR.Parents.AFS_Loader.AnimatorLoad_
{
    public class AnimatorParents_Load_
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
            Load_Parents();
        }
        private void Load_Parents()
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
            LFS_LeafeonParentsFailSafeAnimator.Load_LeafeonParentsFailSafe();
        }
        private void GlaceonParentsFailSafeAnimator()
        {
            LFS_GlaceonParentsFailSafeAnimator.Load_GlaceonParentsFailSafe();
        }
        private void JolteonParentsFailSafeAnimator()
        {
            LFS_JolteonParentsFailSafeAnimator.Load_JolteonParentsFailSafe();
        }
        private void EspeonParentsFailSafeAnimator()
        {
            LFS_EspeonParentsFailSafeAnimator.Load_EspeonParentsFailSafe();
        }
        private void SylveonParentsFailSafeAnimator()
        {
            LFS_SylveonParentsFailSafeAnimator.Load_SylveonParentsFailSafe();
        }
        private void VaporeonParentsFailSafeAnimator()
        {
            LFS_VaporeonParentsFailSafeAnimator.Load_VaporeonParentsFailSafe();
        }
        private void UmbreonParentsFailSafeAnimator()
        {
            LFS_UmbreonParentsFailSafeAnimator.Load_UmbreonParentsFailSafe();
        }
        private void FlareonParentsFailSafeAnimator()
        {
            LFS_FlareonParentsFailSafeAnimator.Load_FlareonParentsFailSafe();
        }
        private void NoivernParentsFailSafeAnimator()
        {
            LFS_NoivernParentsFailSafeAnimator.Load_NoivernParentsFailSafe();
        }
        private void AbsolParentsFailSafeAnimator()
        {
            LFS_AbsolParentsFailSafeAnimator.Load_AbsolParentsFailSafe();
        }
        private void BeedrillParentsFailSafeAnimator()
        {
            LFS_BeedrillParentsFailSafeAnimator.Load_BeedrillParentsFailSafe();
        }
        private void BraixenParentsFailSafeAnimator()
        {
            LFS_BraixenParentsFailSafeAnimator.Load_BraixenParentsFailSafe();
        }
        private void CinderaceParentsFailSafeAnimator()
        {
            LFS_CinderaceParentsFailSafeAnimator.Load_CinderaceParentsFailSafe();
        }
        private void DelphoxParentsFailSafeAnimator()
        {
            LFS_DelphoxParentsFailSafeAnimator.Load_DelphoxParentsFailSafe();
        }
        private void DragapultParentsFailSafeAnimator()
        {
            LFS_DragapultParentsFailSafeAnimator.Load_DragapultParentsFailSafe();
        }
        private void FrostlassParentsFailSafeAnimator()
        {
            LFS_FrostlassParentsFailSafeAnimator.Load_FrostlassParentsFailSafe();
        }
        private void GarchompParentsFailSafeAnimator()
        {
            LFS_GarchompParentsFailSafeAnimator.Load_GarchompParentsFailSafe();
        }
        private void HattereneParentsFailSafeAnimator()
        {
            LFS_HattereneParentsFailSafeAnimator.Load_HattereneParentsFailSafe();
        }
        private void LopunnyParentsFailSafeAnimator()
        {
            LFS_LopunnyParentsFailSafeAnimator.Load_LopunnyParentsFailSafe();
        }
        private void LucarioParentsFailSafeAnimator()
        {
            LFS_LucarioParentsFailSafeAnimator.Load_LucarioParentsFailSafe();
        }
        private void LunalaParentsFailSafeAnimator()
        {
            LFS_LunalaParentsFailSafeAnimator.Load_LunalaParentsFailSafe();
        }
        private void MeowscaradaParentsFailSafeAnimator()
        {
            LFS_MeowscaradaParentsFailSafeAnimator.Load_MeowscaradaParentsFailSafe();
        }
        private void PheromosaParentsFailSafeAnimator()
        {
            LFS_PheromosaParentsFailSafeAnimator.Load_PheromosaParentsFailSafe();
        }
        private void PrimarinaParentsFailSafeAnimator()
        {
            LFS_PrimarinaParentsFailSafeAnimator.Load_PrimarinaParentsFailSafe();
        }
        private void ZoroarkParentsFailSafeAnimator()
        {
            LFS_ZoroarkParentsFailSafeAnimator.Load_ZoroarkParentsFailSafe();
        }
    }
}
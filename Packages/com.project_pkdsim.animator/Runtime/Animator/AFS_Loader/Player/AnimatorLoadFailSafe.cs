using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.PLAYER;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Player.AFS_Loader.AnimatorLoadFailSafe
{
    public class AnimatorPlayer_LoadFailSafe
    {
        private PL_LFS_Animator LFS_PlayerFailSafeAnimator;
        public void FailSafe()
        {
            Debug.Log("Animator is Loading FailSafe");
            LoadFailSafePlayer_AnimatorControllers();
        }
        private void LoadFailSafePlayer_AnimatorControllers()
        {
            PlayerFailSafeAnimator();
        }
        private void PlayerFailSafeAnimator()
        {
            LFS_PlayerFailSafeAnimator.LoadFailSafePlayer_AnimatorController();
        }
    }
}
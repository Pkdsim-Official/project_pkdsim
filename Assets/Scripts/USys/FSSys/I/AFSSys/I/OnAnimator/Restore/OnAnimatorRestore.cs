using project_pkdsim.USys.AnimatorFailSafeSys.Modules.DIsableFallbackSys;
using UnityEngine;

namespace project_pkdsim.USys.AnimatorFailSafeSys.Modules.OnAnimator.Restore
{
	public class AFSSysF_OnAnimatorRestore : MonoBehaviour 
	{
		private AFSysF_DIsableFallbackSys DIsableFallbackSys;
		private bool fallbackEnabled = false;
		private Animator PrimaryAnimator;

		public void OnAnimatorRestore()
        {
            if (fallbackEnabled && PrimaryAnimator != null && PrimaryAnimator.runtimeAnimatorController)
            {
                Debug.Log("Animator restored. Disabling fallback system.");
                DIsableFallbackSys.DisableFallbackSystem();
            }
        }
	}
}
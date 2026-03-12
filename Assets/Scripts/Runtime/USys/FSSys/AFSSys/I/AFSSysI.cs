using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.Modules.OnAnimator.Trigger;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.Modules.DIsableFallbackSys;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.Modules.EnableFallbackSys;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.Modules.OnAnimator.Restore;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.Modules
{
    public class AFSSysI : MonoBehaviour
    {
        private AFSysF_DIsableFallbackSys DIsabler_FallbackSys;
        private AFSysF_EnableFallbackSys Enabler_FallbackSystem;
        private AFSSysF_OnAnimatorRestore OnAnimatorRestore;
        private AFSSysF_OnAnimatorTrigger OnAnimatorTrigger;

        public void AFSSys_I() 
        {
            LoadEnabler_FallbackSystem();
            LoadDisabler_FallbackSystem();
            LoadOA_OnAnimatorRestore();
            LoadOA_OnAnimatorTrigger();
        }
        private void LoadOA_OnAnimatorRestore()
        {
            OnAnimatorRestore = new AFSSysF_OnAnimatorRestore();
            OnAnimatorRestore.OnAnimatorRestore();
        }
        private void LoadOA_OnAnimatorTrigger()
        {
            OnAnimatorTrigger = new AFSSysF_OnAnimatorTrigger();
            OnAnimatorTrigger.OnAnimatorTrigger();
        }
        private void LoadEnabler_FallbackSystem()
        {
            Enabler_FallbackSystem = new AFSysF_EnableFallbackSys();
            Enabler_FallbackSystem.EnableFallbackSystem();
        }

        private void LoadDisabler_FallbackSystem()
        {
            DIsabler_FallbackSys = new AFSysF_DIsableFallbackSys();
            DIsabler_FallbackSys.DisableFallbackSystem();
        }
    }
}
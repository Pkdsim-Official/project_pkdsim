using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.idlebaseanimation;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.movementbasedanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Dad.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Animator_I
{
	public class LFS_DelphoxFailSafe : MonoBehaviour 
	{
		public Animator DelphoxParentDad_Animator;
		public RuntimeAnimatorController someController;

		private DelphoxConverterAnimatorController LFSDelphox_AnimatorCCA;
		private DelphoxParentDad_MovementAnimatorController LFSDelphox_AnimatorCMA;
		private Delphox_IdleAnimatorController LFSDelphox_AnimatorICA;


		public void LoadFailSafeDelphox_AnimatorController()
		{
			LoadFailSafeDelphox_ConvertToAnimatorController();
			LoadFailSafeDelphox_MovementAnimatorController();
			LoadFailSafeDelphox_IdleAnimatorController();
		}
		private void LoadFailSafeDelphox_ConvertToAnimatorController()
		{
			LFSDelphox_AnimatorCCA.DLConverterAnimatorController();
		}
		private void LoadFailSafeDelphox_MovementAnimatorController()
		{
			LFSDelphox_AnimatorCMA.DLMovementAnimatorController();
		}
		private void LoadFailSafeDelphox_IdleAnimatorController()
		{
			LFSDelphox_AnimatorICA.DL_IdleAnimatorController();
		}
	}
}
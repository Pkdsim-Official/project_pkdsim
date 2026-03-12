using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.idlebaseanimation;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.movementbasedanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.Animator_I
{
	public class LFS_DelphoxFailSafe : MonoBehaviour 
	{
		public Animator DelphoxParentMom_Animator;
		public RuntimeAnimatorController someController;

		private DelphoxParentMom_ConverterAnimatorController LFSDelphox_AnimatorCCA;
		private DelphoxParentMom_MovementAnimatorController LFSDelphox_AnimatorCMA;
		private DelphoxParentMom_IdleAnimatorController LFSDelphox_AnimatorICA;


		public void LoadFailSafeDelphox_AnimatorController()
		{
			LoadFailSafeVespiquen_ConvertToAnimatorController();
			LoadFailSafeVespiquen_MovementAnimatorController();
			LoadFailSafeVespiquen_IdleAnimatorController();
		}
		private void LoadFailSafeVespiquen_ConvertToAnimatorController()
		{
			LFSDelphox_AnimatorCCA.DLParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeVespiquen_MovementAnimatorController()
		{
			LFSDelphox_AnimatorCMA.DLParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeVespiquen_IdleAnimatorController()
		{
			LFSDelphox_AnimatorICA.DLParentMom_IdleAnimatorController();
		}
	}
}
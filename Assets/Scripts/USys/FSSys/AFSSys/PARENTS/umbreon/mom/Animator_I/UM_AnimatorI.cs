using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.idlebaseanimation;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.movementbasedanimations;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.Animator_I
{
	public class LFS_VespiquenFailSafe : MonoBehaviour
	{
		public Animator UmbreonParentMom_Animator;
		public RuntimeAnimatorController someController;

		private UmbreonParentMom_ConverterAnimatorController LFSUmbreon_AnimatorCCA;
		private UmbreonParentMom_MovementAnimatorController LFSUmbreon_AnimatorCMA;
		private UmbreonParentMom_IdleAnimatorController LFSUmbreon_AnimatorICA;


		public void LoadFailSafeUmbreon_AnimatorController()
		{
			LoadFailSafeVespiquen_ConvertToAnimatorController();
			LoadFailSafeVespiquen_MovementAnimatorController();
			LoadFailSafeVespiquen_IdleAnimatorController();
		}
		private void LoadFailSafeVespiquen_ConvertToAnimatorController()
		{
			LFSUmbreon_AnimatorCCA.UMParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeVespiquen_MovementAnimatorController()
		{
			LFSUmbreon_AnimatorCMA.UMParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeVespiquen_IdleAnimatorController()
		{
			LFSUmbreon_AnimatorICA.UMParentMom_IdleAnimatorController();
		}
	}
}
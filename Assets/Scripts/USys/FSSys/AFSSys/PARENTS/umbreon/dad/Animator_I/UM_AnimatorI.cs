
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.movementbasedanimations;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.idlebaseanimation;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.converteranimations;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.Animator_I
{
	public class UMParentDad_AnimatorI : MonoBehaviour
	{
		public Animator UmbreonParentDad_Animator;
		public RuntimeAnimatorController someController;

		private UmbreonParentDad_ConverterAnimatorController UmbreonParentDad_AnimatorCCA;
		private UmbreonParentDad_MovementAnimatorController UmbreonParentDad_AnimatorCMA;
		private UmbreonParentDad_AnimatorIdleController UmbreonParentDad_AnimatorICA;

		public void UmbreonParentDad_AnimatorController()
		{
			LoadFailSafeUmbreon_ConvertToAnimatorController();
			LoadFailSafeUmbreon_MovementAnimatorController();
			LoadFailSafeUmbreon_IdleAnimatorController();
		}
		private void LoadFailSafeUmbreon_ConvertToAnimatorController()
		{
			UmbreonParentDad_AnimatorCCA.UMParentDad_ConverterAnimatorController();
		}
		private void LoadFailSafeUmbreon_MovementAnimatorController()
		{
			UmbreonParentDad_AnimatorCMA.UMParentDad_MovementAnimatorController();
		}
		private void LoadFailSafeUmbreon_IdleAnimatorController()
		{
			UmbreonParentDad_AnimatorICA.UMParentDad_IdleAnimatorController();
		}
	}
}
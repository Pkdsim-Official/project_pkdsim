using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.idlebaseanimation;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.movementbasedanimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.Animator_I
{	public class NoivernParentMom_FailSafe : MonoBehaviour 
	{
		public Animator NoivernParentMom_Animator;
		public RuntimeAnimatorController someController;
		private NoivernParentMom_ConverterAnimatorController NoivernParentMom_AnimatorCCA;
		private NoivernParentMom_MovementAnimatorController NoivernParentMom_AnimatorCMA;
		private NoivernParentMom_IdleAnimatorController NoivernParentMom_AnimatorICA;

		public void LoadFailSafeNoivernParentMom_AnimatorController()
		{
			LoadFailSafeNoivernParentMom_ConvertToAnimatorController();
			LoadFailSafeNoivernParentMom_MovementAnimatorController();
			LoadFailSafeNoivernParentMom_IdleAnimatorController();
		}
		private void LoadFailSafeNoivernParentMom_ConvertToAnimatorController()
		{
			NoivernParentMom_AnimatorCCA.NOI_ConverterAnimatorController();
		}
		private void LoadFailSafeNoivernParentMom_MovementAnimatorController()
		{
			NoivernParentMom_AnimatorCMA.NOIMovementAnimatorController();
		}
		private void LoadFailSafeNoivernParentMom_IdleAnimatorController()
		{
			NoivernParentMom_AnimatorICA.NOI_IdleAnimatorController();
		}
	}
}
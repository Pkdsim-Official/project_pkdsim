using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.Dad.Animator_I
{
	public class NoivernFailSafe : MonoBehaviour 
	{
		public Animator NoivernParentDad_Animator;
		public RuntimeAnimatorController someController;
		private NoivernParentDad_ConverterToAnimatorController NoivernParentDad_AnimatorCCA;
		private NoivernParentDad_AnimatorMovementController NoivernParentDad_AnimatorCMA;
		private NoivernParentDad_IdleAnimatorController NoivernParentDad_AnimatorICA;

		public void LoadFailSafeNoivernParentDad_AnimatorController()
		{
			LoadFailSafeNoivernParentDad_ConvertToAnimatorController();
			LoadFailSafeNoivernParentDad_MovementAnimatorController();
			LoadFailSafeNoivernParentDad_IdleAnimatorController();
		}
		private void LoadFailSafeNoivernParentDad_ConvertToAnimatorController()
		{
			NoivernParentDad_AnimatorCCA.NOI_ConverterToAnimatorController();
		}
		private void LoadFailSafeNoivernParentDad_MovementAnimatorController()
		{
			NoivernParentDad_AnimatorCMA.NOIMovementAnimatorController();
		}
		private void LoadFailSafeNoivernParentDad_IdleAnimatorController()
		{
			NoivernParentDad_AnimatorICA.NOI_IdleAnimatorController();
		}
	}
}
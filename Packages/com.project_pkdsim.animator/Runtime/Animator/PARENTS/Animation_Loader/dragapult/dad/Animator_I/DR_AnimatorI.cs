using project_pkdsim.ANIMATOR.Parents.Dragapult.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Dragapult.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Dragapult.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Dragapult.Animator_I
{
	public class DragapultFailSafe : MonoBehaviour 
	{
		public Animator DelphoxParentDad_Animator;
		public RuntimeAnimatorController someController;

		private DelphoxParentDad_ConverterToAnimatorController DelphoxParentDad_AnimatorCCA;
		private DelphoxParentDad_AnimatorMovementController DelphoxParentDad_AnimatorCMA;
		private DelphoxParentDad_IdleAnimatorController DelphoxParentDad_AnimatorICA;


		public void LoadFailSafeDelphoxParentDad_AnimatorController()
		{
			LoadFailSafeDelphoxParentDad_ConvertToAnimatorController();
			LoadFailSafeDelphoxParentDad_MovementAnimatorController();
			LoadFailSafeDelphoxParentDad_IdleAnimatorController();
		}
		private void LoadFailSafeDelphoxParentDad_ConvertToAnimatorController()
		{
			DelphoxParentDad_AnimatorCCA.DR_ConverterToAnimatorController();
		}
		private void LoadFailSafeDelphoxParentDad_MovementAnimatorController()
		{
			DelphoxParentDad_AnimatorCMA.DRMovementAnimatorController();
		}
		private void LoadFailSafeDelphoxParentDad_IdleAnimatorController()
		{
			DelphoxParentDad_AnimatorICA.DR_IdleAnimatorController();
		}
	}
}
using project_pkdsim.ANIMATOR.Parents.Delphox.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Delphox.Mom.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Delphox.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Delphox.Mom.Animator_I
{
	public class DelphoxFailSafe : MonoBehaviour 
	{
		public Animator DelphoxParentMom_Animator;
		public RuntimeAnimatorController someController;

		private DelphoxParentMom_ConverterToAnimatorController DelphoxParentMom_AnimatorCCA;
		private DelphoxParentMom_AnimatorMovementController DelphoxParentMom_AnimatorCMA;
		private DelphoxParentMom_IdleAnimatorController DelphoxParentMom_AnimatorICA;


		public void LoadFailSafeDelphoxParentMom_AnimatorController()
		{
			LoadFailSafeDelphoxParentMom_ConvertToAnimatorController();
			LoadFailSafeDelphoxParentMom_MovementAnimatorController();
			LoadFailSafeDelphoxParentMom_IdleAnimatorController();
		}
		private void LoadFailSafeDelphoxParentMom_ConvertToAnimatorController()
		{
			DelphoxParentMom_AnimatorCCA.DL_ConverterToAnimatorController();
		}
		private void LoadFailSafeDelphoxParentMom_MovementAnimatorController()
		{
			DelphoxParentMom_AnimatorCMA.DLMovementAnimatorController();
		}
		private void LoadFailSafeDelphoxParentMom_IdleAnimatorController()
		{
			DelphoxParentMom_AnimatorICA.DL_IdleAnimatorController();
		}
	}
}
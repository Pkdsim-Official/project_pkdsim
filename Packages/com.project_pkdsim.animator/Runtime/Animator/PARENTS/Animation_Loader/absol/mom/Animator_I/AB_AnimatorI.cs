using project_pkdsim.ANIMATOR.Parents.Absol.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Absol.Mom.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Absol.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Absol.Mom.Animator_I
{
	public class AbsolFailSafe : MonoBehaviour 
	{
		public Animator AbsolParent_Animator;
		public RuntimeAnimatorController someController;

		private AbsolParent_ConverterToAnimatorController AbsolParent_AnimatorCCA;
		private AbsolParent_AnimatorMovementController AbsolParent_AnimatorCMA;
		private AbsolParent_IdleAnimatorController AbsolParent_AnimatorICA;


		public void LoadFailSafeAbsolParent_AnimatorController()
		{
			LoadFailSafeAbsolParent_ConvertToAnimatorController();
			LoadFailSafeAbsolParent_MovementAnimatorController();
			LoadFailSafeAbsolParent_IdleAnimatorController();
		}
		private void LoadFailSafeAbsolParent_ConvertToAnimatorController()
		{
			AbsolParent_AnimatorCCA.AB_ConverterToAnimatorController();
		}
		private void LoadFailSafeAbsolParent_MovementAnimatorController()
		{
			AbsolParent_AnimatorCMA.ABMovementAnimatorController();
		}
		private void LoadFailSafeAbsolParent_IdleAnimatorController()
		{
			AbsolParent_AnimatorICA.AB_IdleAnimatorController();
		}
	}
}
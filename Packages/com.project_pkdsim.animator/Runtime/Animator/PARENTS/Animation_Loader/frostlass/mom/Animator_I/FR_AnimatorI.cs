using project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.Animator_I
{
	public class FrostlassFailSafe : MonoBehaviour 
	{
		public Animator FrostlassParentMom_Animator;
		public RuntimeAnimatorController someController;

		private FrostlassParentMom_ConverterToAnimatorController FrostlassParentMom_AnimatorCCA;
		private FrostlassParentMom_AnimatorMovementController FrostlassParentMom_AnimatorCMA;
		private FrostlassParentMom_IdleAnimatorController FrostlassParentMom_AnimatorICA;


		public void LoadFailSafeFrostlassParentMom_AnimatorController()
		{
			LoadFailSafeFrostlassParentMom_ConvertToAnimatorController();
			LoadFailSafeFrostlassParentMom_MovementAnimatorController();
			LoadFailSafeFrostlassParentMom_IdleAnimatorController();
		}
		private void LoadFailSafeFrostlassParentMom_ConvertToAnimatorController()
		{
			FrostlassParentMom_AnimatorCCA.FR_ConverterToAnimatorController();
		}
		private void LoadFailSafeFrostlassParentMom_MovementAnimatorController()
		{
			FrostlassParentMom_AnimatorCMA.FRMovementAnimatorController();
		}
		private void LoadFailSafeFrostlassParentMom_IdleAnimatorController()
		{
			FrostlassParentMom_AnimatorICA.FR_IdleAnimatorController();
		}
	}
}
using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.Animator_I
{
	public class FrostlassFailSafe : MonoBehaviour 
	{
		public Animator FrostlassParentDad_Animator;
		public RuntimeAnimatorController someController;

		private FrostlassParentDad_ConverterAnimatorController FrostlassParentDad_AnimatorCCA;
		private FrostlassParentDad_MovementAnimatorController FrostlassParentDad_AnimatorCMA;
		private FrostlassParentDad_IdleAnimatorController FrostlassParentDad_AnimatorICA;


		public void LoadFailSafeFrostlassParentDad_AnimatorController()
		{
			LoadFailSafeFrostlassParentDad_ConvertToAnimatorController();
			LoadFailSafeFrostlassParentDad_MovementAnimatorController();
			LoadFailSafeFrostlassParentDad_IdleAnimatorController();
		}
		private void LoadFailSafeFrostlassParentDad_ConvertToAnimatorController()
		{
			FrostlassParentDad_AnimatorCCA.FR_ConverterAnimatorController();
		}
		private void LoadFailSafeFrostlassParentDad_MovementAnimatorController()
		{
			FrostlassParentDad_AnimatorCMA.FRMovementAnimatorController();
		}
		private void LoadFailSafeFrostlassParentDad_IdleAnimatorController()
		{
			FrostlassParentDad_AnimatorICA.FR_IdleAnimatorController();
		}
	}
}
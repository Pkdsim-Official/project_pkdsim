using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.Dadidlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.Dadmovementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.Dadconverteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.DadAnimator_I
{
	public class FrostlassFailSafe : MonoBehaviour 
	{
		public Animator FrostlassParentDad_Animator;
		public RuntimeAnimatorController someController;

		private FrostlassParentDad_ConverterToAnimatorController FrostlassParentDad_AnimatorCCA;
		private FrostlassParentDad_AnimatorMovementController FrostlassParentDad_AnimatorCMA;
		private FrostlassParentDad_IdleAnimatorController FrostlassParentDad_AnimatorICA;


		public void LoadFailSafeFrostlassParentDad_AnimatorController()
		{
			LoadFailSafeFrostlassParentDad_ConvertToAnimatorController();
			LoadFailSafeFrostlassParentDad_MovementAnimatorController();
			LoadFailSafeFrostlassParentDad_IdleAnimatorController();
		}
		private void LoadFailSafeFrostlassParentDad_ConvertToAnimatorController()
		{
			FrostlassParentDad_AnimatorCCA.FR_ConverterToAnimatorController();
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
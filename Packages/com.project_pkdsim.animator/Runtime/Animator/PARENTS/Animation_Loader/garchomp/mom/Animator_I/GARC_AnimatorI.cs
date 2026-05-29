using project_pkdsim.ANIMATOR.Parents.Garchomp.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Garchomp.Mom.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Garchomp.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Garchomp.Mom.Animator_I
{
	public class GarchompFailSafe : MonoBehaviour 
	{
		public Animator Garchomp_Animator;
		public RuntimeAnimatorController someController;

		private Garchomp_ConverterToAnimatorController Garchomp_AnimatorCCA;
		private GarchompParent_AnimatorMovementController Garchomp_AnimatorCMA;
		private Garchomp_IdleAnimatorController Garchomp_AnimatorICA;


		public void LoadFailSafeGarchomp_AnimatorController()
		{
			LoadFailSafeGarchomp_ConvertToAnimatorController();
			LoadFailSafeGarchomp_MovementAnimatorController();
			LoadFailSafeGarchomp_IdleAnimatorController();
		}
		private void LoadFailSafeGarchomp_ConvertToAnimatorController()
		{
			Garchomp_AnimatorCCA.GARC_ConverterToAnimatorController();
		}
		private void LoadFailSafeGarchomp_MovementAnimatorController()
		{
			Garchomp_AnimatorCMA.GARCMovementAnimatorController();
		}
		private void LoadFailSafeGarchomp_IdleAnimatorController()
		{
			Garchomp_AnimatorICA.GARC_IdleAnimatorController();
		}
	}
}
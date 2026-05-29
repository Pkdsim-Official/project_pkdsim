using project_pkdsim.ANIMATOR.Parents.Gardevoir.Dad.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Gardevoir.Dad.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Gardevoir.Dad.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Gardevoir.Dad.Animator_I
{
	public class GardevoirFailSafe : MonoBehaviour 
	{
		public Animator Gardevoir_Animator;
		public RuntimeAnimatorController someController;

		private Gardevoir_ConverterToAnimatorController Gardevoir_AnimatorCCA;
		private GardevoirParent_AnimatorMovementController Gardevoir_AnimatorCMA;
		private Gardevoir_IdleAnimatorController Gardevoir_AnimatorICA;


		public void LoadFailSafeGardevoir_AnimatorController()
		{
			LoadFailSafeGardevoir_ConvertToAnimatorController();
			LoadFailSafeGardevoir_MovementAnimatorController();
			LoadFailSafeGardevoir_IdleAnimatorController();
		}
		private void LoadFailSafeGardevoir_ConvertToAnimatorController()
		{
			Gardevoir_AnimatorCCA.GARD_ConverterToAnimatorController();
		}
		private void LoadFailSafeGardevoir_MovementAnimatorController()
		{
			Gardevoir_AnimatorCMA.GARDMovementAnimatorController();
		}
		private void LoadFailSafeGardevoir_IdleAnimatorController()
		{
			Gardevoir_AnimatorICA.GARD_IdleAnimatorController();
		}
	}
}
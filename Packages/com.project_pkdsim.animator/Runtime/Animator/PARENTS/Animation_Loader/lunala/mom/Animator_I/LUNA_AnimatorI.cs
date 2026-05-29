using project_pkdsim.ANIMATOR.Parents.Lunala.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Lunala.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lunala.Mom.Animator_I
{
	public class LunalaFailSafe : MonoBehaviour 
	{
		public Animator Lunala_Animator;
		public RuntimeAnimatorController someController;

		private Lunala_ConverterToAnimatorController Lunala_AnimatorCCA;
		private LunalaParent_AnimatorMovementController Lunala_AnimatorCMA;
		private Lunala_IdleAnimatorController Lunala_AnimatorICA;


		public void LoadFailSafeLunala_AnimatorController()
		{
			LoadFailSafeLunala_ConvertToAnimatorController();
			LoadFailSafeLunala_MovementAnimatorController();
			LoadFailSafeLunala_IdleAnimatorController();
		}
		private void LoadFailSafeLunala_ConvertToAnimatorController()
		{
			Lunala_AnimatorCCA.LUNA_ConverterToAnimatorController();
		}
		private void LoadFailSafeLunala_MovementAnimatorController()
		{
			Lunala_AnimatorCMA.LUNAMovementAnimatorController();
		}
		private void LoadFailSafeLunala_IdleAnimatorController()
		{
			Lunala_AnimatorICA.LUNA_IdleAnimatorController();
		}
	}
}
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.Animator_I
{
	public class VespiquenFailSafe : MonoBehaviour 
	{
		public Animator Vespiquen_Animator;
		public RuntimeAnimatorController someController;

		private Vespiquen_ConverterToAnimatorController Vespiquen_AnimatorCCA;
		private VespiquenParent_AnimatorMovementController Vespiquen_AnimatorCMA;
		private Vespiquen_IdleAnimatorController Vespiquen_AnimatorICA;


		public void LoadFailSafeVespiquen_AnimatorController()
		{
			LoadFailSafeVespiquen_ConvertToAnimatorController();
			LoadFailSafeVespiquen_MovementAnimatorController();
			LoadFailSafeVespiquen_IdleAnimatorController();
		}
		private void LoadFailSafeVespiquen_ConvertToAnimatorController()
		{
			Vespiquen_AnimatorCCA.VE_ConverterToAnimatorController();
		}
		private void LoadFailSafeVespiquen_MovementAnimatorController()
		{
			Vespiquen_AnimatorCMA.VEMovementAnimatorController();
		}
		private void LoadFailSafeVespiquen_IdleAnimatorController()
		{
			Vespiquen_AnimatorICA.VE_IdleAnimatorController();
		}
	}
}
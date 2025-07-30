using project_pkdsim.ANIMATOR.Parents.Vespiquen.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Animator_I
{
	public class LFS_VespiquenFailSafe : MonoBehaviour 
	{
		public Animator Vespiquen_Animator;
		public RuntimeAnimatorController someController;

		private FrostlassParentMom_ConverterAnimatorController LFSFrostlass_AnimatorCCA;
		private FrostlassParentMom_AnimatorBaseMovementController LFSFrostlass_AnimatorCMA;
		private FrostlassParentMom_IdleAnimatorController LFSFrostlass_AnimatorICA;


		public void LoadFailSafeVespiquen_AnimatorController()
		{
			LoadFailSafeVespiquen_ConvertToAnimatorController();
			LoadFailSafeVespiquen_MovementAnimatorController();
			LoadFailSafeVespiquen_IdleAnimatorController();
		}
		private void LoadFailSafeVespiquen_ConvertToAnimatorController()
		{
			LFSFrostlass_AnimatorCCA.VEParentMom_ConverterToAnimatorController();
		}
		private void LoadFailSafeVespiquen_MovementAnimatorController()
		{
			LFSFrostlass_AnimatorCMA.VEParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeVespiquen_IdleAnimatorController()
		{
			LFSFrostlass_AnimatorICA.VEParentMom_IdleAnimatorController();
		}
	}
}
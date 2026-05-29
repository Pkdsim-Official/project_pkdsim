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

		private Vespiquen_ConverterToAnimatorController LFSVespiquen_AnimatorCCA;
		private VespiquenParent_AnimatorMovementController LFSVespiquen_AnimatorCMA;
		private Vespiquen_IdleAnimatorController LFSVespiquen_AnimatorICA;


		public void LoadFailSafeVespiquen_AnimatorController()
		{
			LoadFailSafeVespiquen_ConvertToAnimatorController();
			LoadFailSafeVespiquen_MovementAnimatorController();
			LoadFailSafeVespiquen_IdleAnimatorController();
		}
		private void LoadFailSafeVespiquen_ConvertToAnimatorController()
		{
			LFSVespiquen_AnimatorCCA.VE_ConverterToAnimatorController();
		}
		private void LoadFailSafeVespiquen_MovementAnimatorController()
		{
			LFSVespiquen_AnimatorCMA.VEMovementAnimatorController();
		}
		private void LoadFailSafeVespiquen_IdleAnimatorController()
		{
			LFSVespiquen_AnimatorICA.VE_IdleAnimatorController();
		}
	}
}
using project_pkdsim.ANIMATOR.NPC.Vespiquen.idlebaseanimation;
using project_pkdsim.ANIMATOR.NPC.Vespiquen.movementbasedanimations;
using project_pkdsim.ANIMATOR.NPC.Vespiquen.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Vespiquen.Animator_I
{
	public class LFS_VespiquenFailSafe : MonoBehaviour 
	{
		public Animator Vespiquen_Animator;
		public RuntimeAnimatorController someController;

		private VespiquenCoverterAnimatorController LFSVespiquen_AnimatorCCA;
		private Vespiquen_AnimatorBaseMovementController LFSVespiquen_AnimatorCMA;
		private VespiquenIdleAnimatorController LFSVespiquen_AnimatorICA;


		public void LoadFailSafeVespiquen_AnimatorController()
		{
			LoadFailSafeVespiquen_ConvertToAnimatorController();
			LoadFailSafeVespiquen_MovementAnimatorController();
			LoadFailSafeVespiquen_IdleAnimatorController();
		}
		private void LoadFailSafeVespiquen_ConvertToAnimatorController()
		{
			LFSVespiquen_AnimatorCCA.VECoverterToAnimatorController();
		}
		private void LoadFailSafeVespiquen_MovementAnimatorController()
		{
			LFSVespiquen_AnimatorCMA.VEMovementAnimatorController();
		}
		private void LoadFailSafeVespiquen_IdleAnimatorController()
		{
			LFSVespiquen_AnimatorICA.VEIdleAnimatorController();
		}
	}
}
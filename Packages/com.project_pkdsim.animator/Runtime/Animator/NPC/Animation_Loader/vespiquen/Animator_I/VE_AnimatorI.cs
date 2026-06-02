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

		private Vespiquen_ConverterAnimatorController LFSVespiquen_AnimatorCCA;
		private Vespiquen_MovementAnimatorController LFSVespiquen_AnimatorCMA;
		private Vespiquen_IdleAnimatorController LFSVespiquen_AnimatorICA;


		public void LoadFailSafeVespiquen_AnimatorController()
		{
			LoadFailSafeVespiquen_ConvertToAnimatorController();
			LoadFailSafeVespiquen_MovementAnimatorController();
			LoadFailSafeVespiquen_IdleAnimatorController();
		}
		private void LoadFailSafeVespiquen_ConvertToAnimatorController()
		{
			LFSVespiquen_AnimatorCCA.VE_ConverterAnimatorController();
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
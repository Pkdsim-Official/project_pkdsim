using project_pkdsim.ANIMATOR.NPC.Frostlass.idlebaseanimation;
using project_pkdsim.ANIMATOR.NPC.Frostlass.movementbasedanimations;
using project_pkdsim.ANIMATOR.NPC.Frostlass.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Frostlass.Animator_I
{
	public class LFS_FrostlassFailSafe : MonoBehaviour 
	{
		public Animator Frostlass_Animator;
		public RuntimeAnimatorController someController;

		private FrostlassCoverterAnimatorController LFSFrostlass_AnimatorCCA;
		private Frostlass_AnimatorBaseMovementController LFSFrostlass_AnimatorCMA;
		private FrostlassIdleAnimatorController LFSFrostlass_AnimatorICA;


		public void LoadFailSafeFrostlass_AnimatorController()
		{
			LoadFailSafeFrostlass_ConvertToAnimatorController();
			LoadFailSafeFrostlass_MovementAnimatorController();
			LoadFailSafeFrostlass_IdleAnimatorController();
		}
		private void LoadFailSafeFrostlass_ConvertToAnimatorController()
		{
			LFSFrostlass_AnimatorCCA.FRCoverterToAnimatorController();
		}
		private void LoadFailSafeFrostlass_MovementAnimatorController()
		{
			LFSFrostlass_AnimatorCMA.FRMovementAnimatorController();
		}
		private void LoadFailSafeFrostlass_IdleAnimatorController()
		{
			LFSFrostlass_AnimatorICA.FRIdleAnimatorController();
		}
	}
}
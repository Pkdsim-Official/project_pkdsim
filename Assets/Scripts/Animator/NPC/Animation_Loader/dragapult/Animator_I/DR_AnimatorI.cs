using project_pkdsim.Models.ANIMATOR.NPC.Dragapult.idlebaseanimation;
using project_pkdsim.Models.ANIMATOR.NPC.Dragapult.movementbasedanimations;
using project_pkdsim.Models.ANIMATOR.NPC.Dragapult.converteranimations;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Dragapult.Animator_I
{
	public class LFS_DragapultFailSafe : MonoBehaviour 
	{
		public Animator Dragapult_Animator;
		public RuntimeAnimatorController someController;

		private DragapultCoverterAnimatorController LFSDragapult_AnimatorCCA;
		private Dragapult_AnimatorBaseMovementController LFSDragapult_AnimatorCMA;
		private DragapultIdleAnimatorController LFSDragapult_AnimatorICA;


		public void LoadFailSafeDragapult_AnimatorController()
		{
			LoadFailSafeDragapult_ConvertToAnimatorController();
			LoadFailSafeDragapult_MovementAnimatorController();
			LoadFailSafeDragapult_IdleAnimatorController();
		}
		private void LoadFailSafeDragapult_ConvertToAnimatorController()
		{
			LFSDragapult_AnimatorCCA.DRCoverterToAnimatorController();
		}
		private void LoadFailSafeDragapult_MovementAnimatorController()
		{
			LFSDragapult_AnimatorCMA.DRMovementAnimatorController();
		}
		private void LoadFailSafeDragapult_IdleAnimatorController()
		{
			LFSDragapult_AnimatorICA.DRIdleAnimatorController();
		}
	}
}
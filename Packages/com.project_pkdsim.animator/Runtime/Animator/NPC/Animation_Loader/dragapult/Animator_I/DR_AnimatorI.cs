using project_pkdsim.ANIMATOR.NPC.Dragapult.idlebaseanimation;
using project_pkdsim.ANIMATOR.NPC.Dragapult.movementbasedanimations;
using project_pkdsim.ANIMATOR.NPC.Dragapult.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Dragapult.Animator_I
{
	public class LFS_DragapultFailSafe : MonoBehaviour 
	{
		public Animator Dragapult_Animator;
		public RuntimeAnimatorController someController;

		private Dragapult_ConverterToAnimatorController LFSDragapult_AnimatorCCA;
		private Dragapult_AnimatorMovementController LFSDragapult_AnimatorCMA;
		private Dragapult_IdleAnimatorController LFSDragapult_AnimatorICA;


		public void LoadFailSafeDragapult_AnimatorController()
		{
			LoadFailSafeDragapult_ConvertToAnimatorController();
			LoadFailSafeDragapult_MovementAnimatorController();
			LoadFailSafeDragapult_IdleAnimatorController();
		}
		private void LoadFailSafeDragapult_ConvertToAnimatorController()
		{
			LFSDragapult_AnimatorCCA.DR_ConverterToAnimatorController();
		}
		private void LoadFailSafeDragapult_MovementAnimatorController()
		{
			LFSDragapult_AnimatorCMA.DRMovementAnimatorController();
		}
		private void LoadFailSafeDragapult_IdleAnimatorController()
		{
			LFSDragapult_AnimatorICA.DR_IdleAnimatorController();
		}
	}
}
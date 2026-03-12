using Project_Pkdsim.ANIMATOR.Npcs.Dragapult.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Npcs.Dragapult.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Npcs.Dragapult.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Dragapult.Animator_I
{
	public class LFS_DragapultFailSafe : MonoBehaviour 
	{
		public Animator Dragapult_Animator;
		public RuntimeAnimatorController someController;

		private DragapultCoverterAnimatorController LFSDragapult_AnimatorCCA;
		private Dragapult_MovementAnimatorController LFSDragapult_AnimatorCMA;
		private Dragapult_IdleAnimatorController LFSDragapult_AnimatorICA;


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
			LFSDragapult_AnimatorICA.DR_IdleAnimatorController();
		}
	}
}
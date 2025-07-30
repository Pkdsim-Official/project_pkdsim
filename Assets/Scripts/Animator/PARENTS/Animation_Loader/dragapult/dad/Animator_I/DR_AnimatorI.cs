using project_pkdsim.ANIMATOR.Parents.Dragapult.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Dragapult.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Dragapult.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Dragapult.Animator_I
{
	public class LFS_DragapultFailSafe : MonoBehaviour 
	{
		public Animator Dragapult_Animator;
		public RuntimeAnimatorController someController;

		private DragapultConverterAnimatorController LFSDragapult_AnimatorCCA;
		private DragapultParent_AnimatorBaseMovementController LFSDragapult_AnimatorCMA;
		private Dragapult_IdleAnimatorController LFSDragapult_AnimatorICA;


		public void LoadFailSafeDragapult_AnimatorController()
		{
			LoadFailSafeDragapult_ConvertToAnimatorController();
			LoadFailSafeDragapult_MovementAnimatorController();
			LoadFailSafeDragapult_IdleAnimatorController();
		}
		private void LoadFailSafeDragapult_ConvertToAnimatorController()
		{
			LFSDragapult_AnimatorCCA.DRConverterToAnimatorController();
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
using Project_Pkdsim.ANIMATOR.Parents.Dragapult.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Parents.Dragapult.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Parents.Delphox.Dad.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Dragapult.Animator_I
{
	public class LFS_DragapultFailSafe : MonoBehaviour 
	{
		public Animator DragapultParentDad_Animator;
		public RuntimeAnimatorController someController;

		private DragapultConverterAnimatorController LFSDragapult_AnimatorCCA;
		private DragapultParentDad_MovementAnimatorController LFSDragapult_AnimatorCMA;
		private Dragapult_IdleAnimatorController LFSDragapult_AnimatorICA;


		public void LoadFailSafeDragapult_AnimatorController()
		{
			LoadFailSafeDragapult_ConvertToAnimatorController();
			LoadFailSafeDragapult_MovementAnimatorController();
			LoadFailSafeDragapult_IdleAnimatorController();
		}
		private void LoadFailSafeDragapult_ConvertToAnimatorController()
		{
			LFSDragapult_AnimatorCCA.DRConverterAnimatorController();
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
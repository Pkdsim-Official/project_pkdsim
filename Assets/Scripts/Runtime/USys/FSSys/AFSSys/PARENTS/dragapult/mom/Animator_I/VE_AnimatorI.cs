using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.idlebaseanimation;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.movementbasedanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.Animator_I
{
	public class LFS_DragapultFailSafe : MonoBehaviour 
	{
		public Animator DragapultParentMom_Animator;
		public RuntimeAnimatorController someController;

		private DragapultParentMom_ConverterAnimatorController LFSDragapult_AnimatorCCA;
		private DragapultParentMom_MovementAnimatorController LFSDragapult_AnimatorCMA;
		private DragapultParentMom_IdleAnimatorController LFSDragapult_AnimatorICA;


		public void LoadFailSafeDragapult_AnimatorController()
		{
			LoadFailSafeDragapult_ConvertToAnimatorController();
			LoadFailSafeDragapult_MovementAnimatorController();
			LoadFailSafeDragapult_IdleAnimatorController();
		}
		private void LoadFailSafeDragapult_ConvertToAnimatorController()
		{
			LFSDragapult_AnimatorCCA.DRParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeDragapult_MovementAnimatorController()
		{
			LFSDragapult_AnimatorCMA.DRParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeDragapult_IdleAnimatorController()
		{
			LFSDragapult_AnimatorICA.DRParentMom_IdleAnimatorController();
		}
	}
}
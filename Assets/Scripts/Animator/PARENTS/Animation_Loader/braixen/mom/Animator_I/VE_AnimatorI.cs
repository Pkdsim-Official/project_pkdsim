using project_pkdsim.ANIMATOR.Parents.Braixen.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Braixen.Mom.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Braixen.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Braixen.Animator_I
{
	public class LFS_VespiquenFailSafe : MonoBehaviour 
	{
		public Animator BraixenParentMom_Animator;
		public RuntimeAnimatorController someController;

		private BraixenParentMom_ConverterAnimatorController LFSBraixen_AnimatorCCA;
		private BraixenParentMom_MovementAnimatorController LFSBraixen_AnimatorCMA;
		private BraixenParentMom_IdleAnimatorController LFSBraixen_AnimatorICA;


		public void LoadFailSafeBraixen_AnimatorController()
		{
			LoadFailSafeVespiquen_ConvertToAnimatorController();
			LoadFailSafeVespiquen_MovementAnimatorController();
			LoadFailSafeVespiquen_IdleAnimatorController();
		}
		private void LoadFailSafeVespiquen_ConvertToAnimatorController()
		{
			LFSBraixen_AnimatorCCA.BRParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeVespiquen_MovementAnimatorController()
		{
			LFSBraixen_AnimatorCMA.BRParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeVespiquen_IdleAnimatorController()
		{
			LFSBraixen_AnimatorICA.BRParentMom_IdleAnimatorController();
		}
	}
}
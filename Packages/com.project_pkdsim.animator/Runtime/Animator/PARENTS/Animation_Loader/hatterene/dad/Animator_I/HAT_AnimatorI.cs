using project_pkdsim.ANIMATOR.Parents.Hatterene.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Hatterene.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Hatterene.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Hatterene.Animator_I
{
	public class LFS_HattereneFailSafe : MonoBehaviour 
	{
		public Animator Hatterene_Animator;
		public RuntimeAnimatorController someController;

		private HattereneCoverterAnimatorController LFSHatterene_AnimatorCCA;
		private HattereneParent_AnimatorBaseMovementController LFSHatterene_AnimatorCMA;
		private Hatterene_IdleAnimatorController LFSHatterene_AnimatorICA;


		public void LoadFailSafeHatterene_AnimatorController()
		{
			LoadFailSafeHatterene_ConvertToAnimatorController();
			LoadFailSafeHatterene_MovementAnimatorController();
			LoadFailSafeHatterene_IdleAnimatorController();
		}
		private void LoadFailSafeHatterene_ConvertToAnimatorController()
		{
			LFSHatterene_AnimatorCCA.HATCoverterToAnimatorController();
		}
		private void LoadFailSafeHatterene_MovementAnimatorController()
		{
			LFSHatterene_AnimatorCMA.HATMovementAnimatorController();
		}
		private void LoadFailSafeHatterene_IdleAnimatorController()
		{
			LFSHatterene_AnimatorICA.HAT_IdleAnimatorController();
		}
	}
}
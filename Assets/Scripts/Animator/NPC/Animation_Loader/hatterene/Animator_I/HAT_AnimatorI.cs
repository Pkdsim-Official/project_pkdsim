using project_pkdsim.Models.ANIMATOR.NPC.Hatterene.idlebaseanimation;
using project_pkdsim.Models.ANIMATOR.NPC.Hatterene.movementbasedanimations;
using project_pkdsim.Models.ANIMATOR.NPC.Hatterene.converteranimations;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Hatterene.Animator_I
{
	public class LFS_HattereneFailSafe : MonoBehaviour 
	{
		public Animator Hatterene_Animator;
		public RuntimeAnimatorController someController;

		private HattereneCoverterAnimatorController LFSHatterene_AnimatorCCA;
		private Hatterene_AnimatorBaseMovementController LFSHatterene_AnimatorCMA;
		private HattereneIdleAnimatorController LFSHatterene_AnimatorICA;


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
			LFSHatterene_AnimatorICA.HATIdleAnimatorController();
		}
	}
}
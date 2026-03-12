using Project_Pkdsim.ANIMATOR.Npcs.Hatterene.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Npcs.Hatterene.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Npcs.Hatterene.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Hatterene.Animator_I
{
	public class LFS_HattereneFailSafe : MonoBehaviour 
	{
		public Animator Hatterene_Animator;
		public RuntimeAnimatorController someController;

		private HattereneCoverterAnimatorController LFSHatterene_AnimatorCCA;
		private Hatterene_MovementAnimatorController LFSHatterene_AnimatorCMA;
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
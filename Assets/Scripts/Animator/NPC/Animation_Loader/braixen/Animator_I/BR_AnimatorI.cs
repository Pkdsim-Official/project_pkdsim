using project_pkdsim.ANIMATOR.Npcs.Braixen.idlebaseanimation;
using project_pkdsim.ANIMATOR.Npcs.Braixen.movementbasedanimations;
using project_pkdsim.ANIMATOR.Npcs.Braixen.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Braixen.Animator_I
{
	public class LFS_BraixenFailSafe : MonoBehaviour 
	{
		public Animator Braixen_Animator;
		public RuntimeAnimatorController someController;

		private BraixenCoverterAnimatorController LFSBraixen_AnimatorCCA;
		private Braixen_MovementAnimatorController LFSBraixen_AnimatorCMA;
		private Braixen_IdleAnimatorController LFSBraixen_AnimatorICA;


		public void LoadFailSafeBraixen_AnimatorController()
		{
			LoadFailSafeBraixen_ConvertToAnimatorController();
			LoadFailSafeBraixen_MovementAnimatorController();
			LoadFailSafeBraixen_IdleAnimatorController();
		}
		private void LoadFailSafeBraixen_ConvertToAnimatorController()
		{
			LFSBraixen_AnimatorCCA.BRCoverterToAnimatorController();
		}
		private void LoadFailSafeBraixen_MovementAnimatorController()
		{
			LFSBraixen_AnimatorCMA.BRMovementAnimatorController();
		}
		private void LoadFailSafeBraixen_IdleAnimatorController()
		{
			LFSBraixen_AnimatorICA.BR_IdleAnimatorController();
		}
	}
}
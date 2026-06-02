using project_pkdsim.ANIMATOR.NPC.Braixen.idlebaseanimation;
using project_pkdsim.ANIMATOR.NPC.Braixen.movementbasedanimations;
using project_pkdsim.ANIMATOR.NPC.Braixen.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Braixen.Animator_I
{
	public class LFS_BraixenFailSafe : MonoBehaviour 
	{
		public Animator Braixen_Animator;
		public RuntimeAnimatorController someController;

		private Braixen_ConverterAnimatorController LFSBraixen_AnimatorCCA;
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
			LFSBraixen_AnimatorCCA.BR_ConverterAnimatorController();
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
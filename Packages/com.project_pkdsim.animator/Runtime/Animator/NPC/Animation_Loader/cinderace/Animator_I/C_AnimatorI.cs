using project_pkdsim.ANIMATOR.NPC.Cinderace.idlebaseanimation;
using project_pkdsim.ANIMATOR.NPC.Cinderace.movementbasedanimations;
using project_pkdsim.ANIMATOR.NPC.Cinderace.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Cinderace.Animator_I
{
	public class LFS_CinderaceFailSafe : MonoBehaviour 
	{
		public Animator Cinderace_Animator;
		public RuntimeAnimatorController someController;

		private Cinderace_ConverterToAnimatorController LFSCinderace_AnimatorCCA;
		private Cinderace_AnimatorMovementController LFSCinderace_AnimatorCMA;
		private Cinderace_IdleAnimatorController LFSCinderace_AnimatorICA;


		public void LoadFailSafeCinderace_AnimatorController()
		{
			LoadFailSafeCinderace_ConvertToAnimatorController();
			LoadFailSafeCinderace_MovementAnimatorController();
			LoadFailSafeCinderace_IdleAnimatorController();
		}
		private void LoadFailSafeCinderace_ConvertToAnimatorController()
		{
			LFSCinderace_AnimatorCCA.C_ConverterToAnimatorController();
		}
		private void LoadFailSafeCinderace_MovementAnimatorController()
		{
			LFSCinderace_AnimatorCMA.CMovementAnimatorController();
		}
		private void LoadFailSafeCinderace_IdleAnimatorController()
		{
			LFSCinderace_AnimatorICA.C_IdleAnimatorController();
		}
	}
}
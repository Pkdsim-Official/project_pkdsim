using Project_Pkdsim.ANIMATOR.Parents.Cinderace.Dad.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Parents.Cinderace.Dad.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Parents.Cinderace.Dad.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Cinderace.Dad.Animator_I
{
	public class LFS_CinderaceFailSafe : MonoBehaviour
	{
		public Animator CinderaceParentDad_Animator;
		public RuntimeAnimatorController someController;

		private CinderaceParentDad_ConverterAnimatorController LFSCinderace_AnimatorCCA;
		private CinderaceParentDad_MovementAnimatorController LFSCinderace_AnimatorCMA;
		private CinderaceParentDad_IdleAnimatorController LFSCinderace_AnimatorICA;

		public void LoadFailSafeCinderace_AnimatorController()
		{
			LoadFailSafeCinderace_ConvertToAnimatorController();
			LoadFailSafeCinderace_MovementAnimatorController();
			LoadFailSafeCinderace_IdleAnimatorController();
		}
		private void LoadFailSafeCinderace_ConvertToAnimatorController()
		{
			LFSCinderace_AnimatorCCA.CParentDad_ConverterAnimatorController();
		}
		private void LoadFailSafeCinderace_MovementAnimatorController()
		{
			LFSCinderace_AnimatorCMA.CMovementAnimatorController();
		}
		private void LoadFailSafeCinderace_IdleAnimatorController()
		{
			LFSCinderace_AnimatorICA.CParentDad_IdleAnimatorController();
		}
	}
}
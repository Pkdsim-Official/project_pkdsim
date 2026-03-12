using Project_Pkdsim.ANIMATOR.Parents.Cinderace.Mom.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Parents.Cinderace.Mom.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Parents.Cinderace.Mom.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Cinderace.Mom.Animator_I
{
	public class LFS_VespiquenFailSafe : MonoBehaviour 
	{
		public Animator CinderaceParentMom_Animator;
		public RuntimeAnimatorController someController;

		private CinderaceParentMom_ConverterAnimatorController LFSCinderace_AnimatorCCA;
		private CinderaceParentMom_MovementAnimatorController LFSCinderace_AnimatorCMA;
		private CinderaceParentMom_IdleAnimatorController LFSCinderace_AnimatorICA;


		public void LoadFailSafeCinderace_AnimatorController()
		{
			LoadFailSafeVespiquen_ConvertToAnimatorController();
			LoadFailSafeVespiquen_MovementAnimatorController();
			LoadFailSafeVespiquen_IdleAnimatorController();
		}
		private void LoadFailSafeVespiquen_ConvertToAnimatorController()
		{
			LFSCinderace_AnimatorCCA.CParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeVespiquen_MovementAnimatorController()
		{
			LFSCinderace_AnimatorCMA.CParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeVespiquen_IdleAnimatorController()
		{
			LFSCinderace_AnimatorICA.CParentMom_IdleAnimatorController();
		}
	}
}
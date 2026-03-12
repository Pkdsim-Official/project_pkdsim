using Project_Pkdsim.ANIMATOR.Npcs.Cinderace.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Npcs.Cinderace.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Npcs.Cinderace.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Cinderace.Animator_I
{
	public class LFS_CinderaceFailSafe : MonoBehaviour 
	{
		public Animator Cinderace_Animator;
		public RuntimeAnimatorController someController;

		private CinderaceCoverterAnimatorController LFSCinderace_AnimatorCCA;
		private Cinderace_MovementAnimatorController LFSCinderace_AnimatorCMA;
		private Cinderace_IdleAnimatorController LFSCinderace_AnimatorICA;


		public void LoadFailSafeCinderace_AnimatorController()
		{
			LoadFailSafeCinderace_ConvertToAnimatorController();
			LoadFailSafeCinderace_MovementAnimatorController();
			LoadFailSafeCinderace_IdleAnimatorController();
		}
		private void LoadFailSafeCinderace_ConvertToAnimatorController()
		{
			LFSCinderace_AnimatorCCA.CCoverterToAnimatorController();
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
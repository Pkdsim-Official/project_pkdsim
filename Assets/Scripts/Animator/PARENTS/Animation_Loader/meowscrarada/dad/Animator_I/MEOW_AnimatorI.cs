using project_pkdsim.ANIMATOR.Parents.Meowscarada.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Meowscarada.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Meowscarada.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Meowscarada.Animator_I
{
	public class LFS_MeowscaradaFailSafe : MonoBehaviour 
	{
		public Animator Meowscarada_Animator;
		public RuntimeAnimatorController someController;

		private MeowscaradaCoverterAnimatorController LFSMeowscarada_AnimatorCCA;
		private MeowscaradaParent_AnimatorBaseMovementController LFSMeowscarada_AnimatorCMA;
		private Meowscarada_IdleAnimatorController LFSMeowscarada_AnimatorICA;


		public void LoadFailSafeMeowscarada_AnimatorController()
		{
			LoadFailSafeMeowscarada_ConvertToAnimatorController();
			LoadFailSafeMeowscarada_MovementAnimatorController();
			LoadFailSafeMeowscarada_IdleAnimatorController();
		}
		private void LoadFailSafeMeowscarada_ConvertToAnimatorController()
		{
			LFSMeowscarada_AnimatorCCA.MEOWCoverterToAnimatorController();
		}
		private void LoadFailSafeMeowscarada_MovementAnimatorController()
		{
			LFSMeowscarada_AnimatorCMA.MEOWMovementAnimatorController();
		}
		private void LoadFailSafeMeowscarada_IdleAnimatorController()
		{
			LFSMeowscarada_AnimatorICA.MEOW_IdleAnimatorController();
		}
	}
}
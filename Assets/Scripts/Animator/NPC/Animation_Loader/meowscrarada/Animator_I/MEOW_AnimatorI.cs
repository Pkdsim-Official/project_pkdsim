using project_pkdsim.ANIMATOR.NPC.Meowscarada.idlebaseanimation;
using project_pkdsim.ANIMATOR.NPC.Meowscarada.movementbasedanimations;
using project_pkdsim.ANIMATOR.NPC.Meowscarada.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Meowscarada.Animator_I
{
	public class LFS_MeowscaradaFailSafe : MonoBehaviour 
	{
		public Animator Meowscarada_Animator;
		public RuntimeAnimatorController someController;

		private MeowscaradaCoverterAnimatorController LFSMeowscarada_AnimatorCCA;
		private Meowscarada_AnimatorBaseMovementController LFSMeowscarada_AnimatorCMA;
		private MeowscaradaIdleAnimatorController LFSMeowscarada_AnimatorICA;


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
			LFSMeowscarada_AnimatorICA.MEOWIdleAnimatorController();
		}
	}
}
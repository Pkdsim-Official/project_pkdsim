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

		private Meowscarada_ConverterAnimatorController LFSMeowscarada_AnimatorCCA;
		private Meowscarada_MovementAnimatorController LFSMeowscarada_AnimatorCMA;
		private Meowscarada_IdleAnimatorController LFSMeowscarada_AnimatorICA;


		public void LoadFailSafeMeowscarada_AnimatorController()
		{
			LoadFailSafeMeowscarada_ConvertToAnimatorController();
			LoadFailSafeMeowscarada_MovementAnimatorController();
			LoadFailSafeMeowscarada_IdleAnimatorController();
		}
		private void LoadFailSafeMeowscarada_ConvertToAnimatorController()
		{
			LFSMeowscarada_AnimatorCCA.MEOW_ConverterAnimatorController();
		}
		private void LoadFailSafeMeowscarada_MovementAnimatorController()
		{
			LFSMeowscarada_AnimatorCMA.MEOW_MovementAnimatorController();
		}
		private void LoadFailSafeMeowscarada_IdleAnimatorController()
		{
			LFSMeowscarada_AnimatorICA.MEOW_IdleAnimatorController();
		}
	}
}
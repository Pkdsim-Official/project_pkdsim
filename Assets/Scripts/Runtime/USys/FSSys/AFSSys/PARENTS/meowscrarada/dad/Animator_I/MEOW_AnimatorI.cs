using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.idlebaseanimation;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.movementbasedanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Animator_I
{
	public class LFS_MeowscaradaFailSafe : MonoBehaviour 
	{
		public Animator MeowscaradaParentDad_Animator;
		public RuntimeAnimatorController someController;

		private MeowscaradaConverterAnimatorController LFSMeowscarada_AnimatorCCA;
		private MeowscaradaParentDad_MovementAnimatorController LFSMeowscarada_AnimatorCMA;
		private Meowscarada_IdleAnimatorController LFSMeowscarada_AnimatorICA;


		public void LoadFailSafeMeowscarada_AnimatorController()
		{
			LoadFailSafeMeowscarada_ConvertToAnimatorController();
			LoadFailSafeMeowscarada_MovementAnimatorController();
			LoadFailSafeMeowscarada_IdleAnimatorController();
		}
		private void LoadFailSafeMeowscarada_ConvertToAnimatorController()
		{
			LFSMeowscarada_AnimatorCCA.MEOWConverterAnimatorController();
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
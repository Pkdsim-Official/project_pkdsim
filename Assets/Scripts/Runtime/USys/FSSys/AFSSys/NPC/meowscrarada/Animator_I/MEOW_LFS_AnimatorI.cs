using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.idlebaseanimation;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.movementbasedanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.Animator_I
{
	public class LFS_MeowscaradaFailSafe : MonoBehaviour 
	{
		public Animator Meowscarada_Animator;
		public RuntimeAnimatorController someController;

		private Meowscarada_LFS_CoverterAnimatorController LFSMeowscarada_AnimatorCCA;
		private Meowscarada_LFS_MovementAnimatorController LFSMeowscarada_AnimatorCMA;
		private Meowscarada_LFS_IdleAnimatorController LFSMeowscarada_AnimatorICA;


		public void LoadFailSafeMeowscarada_AnimatorController()
		{
			LoadFailSafeMeowscarada_ConvertToAnimatorController();
			LoadFailSafeMeowscarada_MovementAnimatorController();
			LoadFailSafeMeowscarada_IdleAnimatorController();
		}
		private void LoadFailSafeMeowscarada_ConvertToAnimatorController()
		{
			LFSMeowscarada_AnimatorCCA.MEOW_LFS_CoverterToAnimatorController();
		}
		private void LoadFailSafeMeowscarada_MovementAnimatorController()
		{
			LFSMeowscarada_AnimatorCMA.MEOW_LFS_MovementAnimatorController();
		}
		private void LoadFailSafeMeowscarada_IdleAnimatorController()
		{
			LFSMeowscarada_AnimatorICA.MEOW_LFS_IdleAnimatorController();
		}
	}
}
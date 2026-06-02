using project_pkdsim.ANIMATOR.Parents.Meowscarada.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Meowscarada.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Meowscarada.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Meowscarada.Animator_I
{
	public class MeowscaradaFailSafe : MonoBehaviour 
	{
		public Animator Meowscarada_Animator;
		public RuntimeAnimatorController someController;

		private Meowscarada_ConverterAnimatorController Meowscarada_AnimatorCCA;
		private MeowscaradaParent_MovementAnimatorController Meowscarada_AnimatorCMA;
		private Meowscarada_IdleAnimatorController Meowscarada_AnimatorICA;


		public void LoadFailSafeMeowscarada_AnimatorController()
		{
			LoadFailSafeMeowscarada_ConvertToAnimatorController();
			LoadFailSafeMeowscarada_MovementAnimatorController();
			LoadFailSafeMeowscarada_IdleAnimatorController();
		}
		private void LoadFailSafeMeowscarada_ConvertToAnimatorController()
		{
			Meowscarada_AnimatorCCA.MEOW_ConverterAnimatorController();
		}
		private void LoadFailSafeMeowscarada_MovementAnimatorController()
		{
			Meowscarada_AnimatorCMA.MEOW_MovementAnimatorController();
		}
		private void LoadFailSafeMeowscarada_IdleAnimatorController()
		{
			Meowscarada_AnimatorICA.MEOW_IdleAnimatorController();
		}
	}
}
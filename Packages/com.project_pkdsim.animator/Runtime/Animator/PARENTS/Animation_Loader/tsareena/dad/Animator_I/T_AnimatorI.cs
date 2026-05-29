using project_pkdsim.ANIMATOR.Parents.Tsareena.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Tsareena.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Tsareena.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Tsareena.Animator_I
{
	public class TsareenaFailSafe : MonoBehaviour 
	{
		public Animator Tsareena_Animator;
		public RuntimeAnimatorController someController;

		private Tsareena_ConverterToAnimatorController Tsareena_AnimatorCCA;
		private TsareenaParent_AnimatorMovementController Tsareena_AnimatorCMA;
		private Tsareena_IdleAnimatorController Tsareena_AnimatorICA;


		public void LoadFailSafeTsareena_AnimatorController()
		{
			LoadFailSafeTsareena_ConvertToAnimatorController();
			LoadFailSafeTsareena_MovementAnimatorController();
			LoadFailSafeTsareena_IdleAnimatorController();
		}
		private void LoadFailSafeTsareena_ConvertToAnimatorController()
		{
			Tsareena_AnimatorCCA.T_ConverterToAnimatorController();
		}
		private void LoadFailSafeTsareena_MovementAnimatorController()
		{
			Tsareena_AnimatorCMA.TMovementAnimatorController();
		}
		private void LoadFailSafeTsareena_IdleAnimatorController()
		{
			Tsareena_AnimatorICA.T_IdleAnimatorController();
		}
	}
}
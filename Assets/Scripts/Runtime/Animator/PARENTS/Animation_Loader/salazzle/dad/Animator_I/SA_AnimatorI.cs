using Project_Pkdsim.ANIMATOR.Parents.Salazzle.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Parents.Salazzle.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Parents.Salazzle.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Salazzle.Animator_I
{
	public class _SalazzleFailSafe : MonoBehaviour 
	{
		public Animator SalazzleParentDad_Animator;
		public RuntimeAnimatorController someController;

		private Salazzle_ConverterAnimatorController Salazzle_AnimatorCCA;
		private SalazzleParentDad_MovementAnimatorController Salazzle_AnimatorCMA;
		private Salazzle_IdleAnimatorController Salazzle_AnimatorICA;

		public void LoadFailSafeSalazzle_AnimatorController()
		{
			LoadFailSafeSalazzle_ConvertToAnimatorController();
			LoadFailSafeSalazzle_MovementAnimatorController();
			LoadFailSafeSalazzle_IdleAnimatorController();
		}
		private void LoadFailSafeSalazzle_ConvertToAnimatorController()
		{
			Salazzle_AnimatorCCA.SA_ConverterAnimatorController();
		}
		private void LoadFailSafeSalazzle_MovementAnimatorController()
		{
			Salazzle_AnimatorCMA.SA_MovementAnimatorController();
		}
		private void LoadFailSafeSalazzle_IdleAnimatorController()
		{
			Salazzle_AnimatorICA.SA_IdleAnimatorController();
		}
	}
}
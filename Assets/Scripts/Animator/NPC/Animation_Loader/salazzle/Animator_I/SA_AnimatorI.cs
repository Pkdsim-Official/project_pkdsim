using project_pkdsim.Models.ANIMATOR.NPC.Salazzle.idlebaseanimation;
using project_pkdsim.Models.ANIMATOR.NPC.Salazzle.movementbasedanimations;
using project_pkdsim.Models.ANIMATOR.NPC.Salazzle.converteranimations;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Salazzle.Animator_I
{
	public class _SalazzleFailSafe : MonoBehaviour 
	{
		public Animator Salazzle_Animator;
		public RuntimeAnimatorController someController;

		private Salazzle_CoverterAnimatorController Salazzle_AnimatorCCA;
		private Salazzle_AnimatorBaseMovementController Salazzle_AnimatorCMA;
		private Salazzle_IdleAnimatorController Salazzle_AnimatorICA;

		public void LoadFailSafeSalazzle_AnimatorController()
		{
			LoadFailSafeSalazzle_ConvertToAnimatorController();
			LoadFailSafeSalazzle_MovementAnimatorController();
			LoadFailSafeSalazzle_IdleAnimatorController();
		}
		private void LoadFailSafeSalazzle_ConvertToAnimatorController()
		{
			Salazzle_AnimatorCCA.SA_CoverterToAnimatorController();
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
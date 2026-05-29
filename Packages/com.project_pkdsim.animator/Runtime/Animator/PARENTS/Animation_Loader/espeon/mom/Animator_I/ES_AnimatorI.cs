using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Espeon.Mom.Animator_I
{
	public class ES_AnimatorI : MonoBehaviour 
	{
		public Animator Espeon_Animator;
		public RuntimeAnimatorController someController;

		private EspeonParentMom_ConverterToAnimatorController EspeonParentMom_AnimatorCCA;
		private EspeonParentMom_AnimatorMovementController EspeonParentMom_AnimatorCMA;
		private EspeonParentMom_IdleAnimatorController EspeonParentMom_AnimatorICA;


		public void LoadFailSafeEspeonParentMom_AnimatorController()
		{
			LoadFailSafeEspeonParentMom_ConvertToAnimatorController();
			LoadFailSafeEspeonParentMom_MovementAnimatorController();
			LoadFailSafeEspeonParentMom_IdleAnimatorController();
		}
		private void LoadFailSafeEspeonParentMom_ConvertToAnimatorController()
		{
			EspeonParentMom_AnimatorCCA.C_ConverterToAnimatorController();
		}
		private void LoadFailSafeEspeonParentMom_MovementAnimatorController()
		{
			EspeonParentMom_AnimatorCMA.CMovementAnimatorController();
		}
		private void LoadFailSafeEspeonParentMom_IdleAnimatorController()
		{
			EspeonParentMom_AnimatorICA.C_IdleAnimatorController();
		}
	}
}
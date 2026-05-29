using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Espeon.Animator_I
{
	public class ES_AnimatorI : MonoBehaviour 
	{
		public Animator Espeon_Animator;
		public RuntimeAnimatorController someController;

		private EspeonParentDad_ConverterToAnimatorController EspeonParentDad_AnimatorCCA;
		private EspeonParentDad_AnimatorMovementController EspeonParentDad_AnimatorCMA;
		private EspeonParentDad_IdleAnimatorController EspeonParentDad_AnimatorICA;


		public void LoadFailSafeEspeonParentDad_AnimatorController()
		{
			LoadFailSafeEspeonParentDad_ConvertToAnimatorController();
			LoadFailSafeEspeonParentDad_MovementAnimatorController();
			LoadFailSafeEspeonParentDad_IdleAnimatorController();
		}
		private void LoadFailSafeEspeonParentDad_ConvertToAnimatorController()
		{
			EspeonParentDad_AnimatorCCA.C_ConverterToAnimatorController();
		}
		private void LoadFailSafeEspeonParentDad_MovementAnimatorController()
		{
			EspeonParentDad_AnimatorCMA.CMovementAnimatorController();
		}
		private void LoadFailSafeEspeonParentDad_IdleAnimatorController()
		{
			EspeonParentDad_AnimatorICA.C_IdleAnimatorController();
		}
	}
}
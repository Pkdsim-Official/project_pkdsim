using project_pkdsim.ANIMATOR.Parents.Espeon.Dad.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Espeon.Dad.converteranimations;
using project_pkdsim.ANIMATOR.Parents.Espeon.Dad.idlebaseanimation;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Espeon.Dad.Animator_I
{
	public class ES_AnimatorI : MonoBehaviour 
	{
		public Animator EspeonParentDad_Animator;
		public RuntimeAnimatorController someController;

		private EspeonParentDad_ConverterAnimatorController EspeonParentDad_AnimatorCCA;
		private EspeonParentDad_MovementAnimatorController EspeonParentDad_AnimatorCMA;
		private EspeonParentDad_IdleAnimatorController EspeonParentDad_AnimatorICA;


		public void LoadFailSafeEspeonParentDad_AnimatorController()
		{
			LoadFailSafeEspeonParentDad_ConvertToAnimatorController();
			LoadFailSafeEspeonParentDad_MovementAnimatorController();
			LoadFailSafeEspeonParentDad_IdleAnimatorController();
		}
		private void LoadFailSafeEspeonParentDad_ConvertToAnimatorController()
		{
			EspeonParentDad_AnimatorCCA.ESParentDad_ConverterAnimatorController();
		}
		private void LoadFailSafeEspeonParentDad_MovementAnimatorController()
		{
			EspeonParentDad_AnimatorCMA.ESParentDad_MovementAnimatorController();
		}
		private void LoadFailSafeEspeonParentDad_IdleAnimatorController()
		{
			EspeonParentDad_AnimatorICA.ESParentDad_IdleAnimatorController();
		}
	}
}
using project_pkdsim.ANIMATOR.Parents.Espeon.Mom.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Espeon.Mom.converteranimations;
using project_pkdsim.ANIMATOR.Parents.Espeon.Mom.idlebaseanimation;

using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Espeon.Mom.Animator_I
{
	public class ES_AnimatorI : MonoBehaviour 
	{
		public Animator EspeonParentMom_Animator;
		public RuntimeAnimatorController someController;

		private EspeonParentMom_ConverterAnimatorController EspeonParentMom_AnimatorCCA;
		private EspeonParentMom_MovementAnimatorController EspeonParentMom_AnimatorCMA;
		private EspeonParentMom_IdleAnimatorController EspeonParentMom_AnimatorICA;


		public void LoadFailSafeEspeonParentMom_AnimatorController()
		{
			LoadFailSafeEspeonParentMom_ConvertToAnimatorController();
			LoadFailSafeEspeonParentMom_MovementAnimatorController();
			LoadFailSafeEspeonParentMom_IdleAnimatorController();
		}
		private void LoadFailSafeEspeonParentMom_ConvertToAnimatorController()
		{
			EspeonParentMom_AnimatorCCA.ESParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeEspeonParentMom_MovementAnimatorController()
		{
			EspeonParentMom_AnimatorCMA.ESParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeEspeonParentMom_IdleAnimatorController()
		{
			EspeonParentMom_AnimatorICA.ESParentMom_IdleAnimatorController();
		}
	}
}
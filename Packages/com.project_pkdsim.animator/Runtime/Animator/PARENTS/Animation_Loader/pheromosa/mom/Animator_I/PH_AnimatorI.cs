using project_pkdsim.ANIMATOR.Parents.Pheromosa.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.Mom.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Pheromosa.Mom.Animator_I
{
	public class PheromosaFailSafe : MonoBehaviour 
	{
		public Animator PheromosaParentMom_Animator;
		public RuntimeAnimatorController someController;

		private PheromosaParentMom_ConverterToAnimatorController PheromosaParentMom_AnimatorCCA;
		private PheromosaParentMom_AnimatorMovementController PheromosaParentMom_AnimatorCMA;
		private PheromosaParentMom_IdleAnimatorController PheromosaParentMom_AnimatorICA;


		public void LoadFailSafePheromosaParentMom_AnimatorController()
		{
			LoadFailSafePheromosaParentMom_ConvertToAnimatorController();
			LoadFailSafePheromosaParentMom_MovementAnimatorController();
			LoadFailSafePheromosaParentMom_IdleAnimatorController();
		}
		private void LoadFailSafePheromosaParentMom_ConvertToAnimatorController()
		{
			PheromosaParentMom_AnimatorCCA.PH_ConverterToAnimatorController();
		}
		private void LoadFailSafePheromosaParentMom_MovementAnimatorController()
		{
			PheromosaParentMom_AnimatorCMA.PHMovementAnimatorController();
		}
		private void LoadFailSafePheromosaParentMom_IdleAnimatorController()
		{
			PheromosaParentMom_AnimatorICA.PH_IdleAnimatorController();
		}
	}
}
using project_pkdsim.ANIMATOR.Parents.Pheromosa.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Pheromosa.Animator_I
{
	public class PheromosaFailSafe : MonoBehaviour 
	{
		public Animator PheromosaParentDad_Animator;
		public RuntimeAnimatorController someController;

		private PheromosaParentDad_ConverterAnimatorController PheromosaParentDad_AnimatorCCA;
		private PheromosaParentDad_MovementAnimatorController PheromosaParentDad_AnimatorCMA;
		private PheromosaParentDad_IdleAnimatorController PheromosaParentDad_AnimatorICA;


		public void LoadFailSafePheromosaParentDad_AnimatorController()
		{
			LoadFailSafePheromosaParentDad_ConvertToAnimatorController();
			LoadFailSafePheromosaParentDad_MovementAnimatorController();
			LoadFailSafePheromosaParentDad_IdleAnimatorController();
		}
		private void LoadFailSafePheromosaParentDad_ConvertToAnimatorController()
		{
			PheromosaParentDad_AnimatorCCA.PH_ConverterAnimatorController();
		}
		private void LoadFailSafePheromosaParentDad_MovementAnimatorController()
		{
			PheromosaParentDad_AnimatorCMA.PHMovementAnimatorController();
		}
		private void LoadFailSafePheromosaParentDad_IdleAnimatorController()
		{
			PheromosaParentDad_AnimatorICA.PH_IdleAnimatorController();
		}
	}
}
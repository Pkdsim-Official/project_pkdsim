using Project_Pkdsim.ANIMATOR.Parents.Pheromosa.Mom.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Parents.Pheromosa.Mom.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Parents.Pheromosa.Mom.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Pheromosa.Mom.Animator_I
{
	public class LFS_PheromosaFailSafe : MonoBehaviour 
	{
		public Animator PheromosaParentMom_Animator;
		public RuntimeAnimatorController someController;

		private PheromosaParentMom_ConverterAnimatorController LFSPheromosa_AnimatorCCA;
		private PheromosaParentMom_MovementAnimatorController LFSPheromosa_AnimatorCMA;
		private PheromosaParentMom_IdleAnimatorController LFSPheromosa_AnimatorICA;


		public void LoadFailSafePheromosa_AnimatorController()
		{
			LoadFailSafePheromosa_ConvertToAnimatorController();
			LoadFailSafePheromosa_MovementAnimatorController();
			LoadFailSafePheromosa_IdleAnimatorController();
		}
		private void LoadFailSafePheromosa_ConvertToAnimatorController()
		{
			LFSPheromosa_AnimatorCCA.PHParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafePheromosa_MovementAnimatorController()
		{
			LFSPheromosa_AnimatorCMA.PHParentMom_MovementAnimatorController();
		}
		private void LoadFailSafePheromosa_IdleAnimatorController()
		{
			LFSPheromosa_AnimatorICA.PHParentMom_IdleAnimatorController();
		}
	}
}
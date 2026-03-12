using Project_Pkdsim.ANIMATOR.Parents.Pheromosa.Dad.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Parents.Pheromosa.Dad.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Parents.Pheromosa.Dad.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Pheromosa.Dad.Animator_I
{
	public class LFS_PheromosaFailSafe : MonoBehaviour 
	{
		public Animator PheromosaParentDad_Animator;
		public RuntimeAnimatorController someController;

		private PheromosaParentDad_ConverterAnimatorController LFSPheromosa_AnimatorCCA;
		private PheromosaParentDad_MovementAnimatorController LFSPheromosa_AnimatorCMA;
		private PheromosaParentDad_IdleAnimatorController LFSPheromosa_AnimatorICA;

		public void LoadFailSafePheromosa_AnimatorController()
		{
			LoadFailSafePheromosa_ConvertToAnimatorController();
			LoadFailSafePheromosa_MovementAnimatorController();
			LoadFailSafePheromosa_IdleAnimatorController();
		}
		private void LoadFailSafePheromosa_ConvertToAnimatorController()
		{
			LFSPheromosa_AnimatorCCA.PHParentDad_ConverterAnimatorController();
		}
		private void LoadFailSafePheromosa_MovementAnimatorController()
		{
			LFSPheromosa_AnimatorCMA.PHParentDad_MovementAnimatorController();
		}
		private void LoadFailSafePheromosa_IdleAnimatorController()
		{
			LFSPheromosa_AnimatorICA.PHParentDad_IdleAnimatorController();
		}
	}
}
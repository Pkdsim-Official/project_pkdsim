using project_pkdsim.ANIMATOR.Npcs.Pheromosa.idlebaseanimation;
using project_pkdsim.ANIMATOR.Npcs.Pheromosa.movementbasedanimations;
using project_pkdsim.ANIMATOR.Npcs.Pheromosa.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Pheromosa.Animator_I
{
	public class LFS_PheromosaFailSafe : MonoBehaviour 
	{
		public Animator Pheromosa_Animator;
		public RuntimeAnimatorController someController;

		private PheromosaCoverterAnimatorController LFSPheromosa_AnimatorCCA;
		private Pheromosa_MovementAnimatorController LFSPheromosa_AnimatorCMA;
		private Pheromosa_IdleAnimatorController LFSPheromosa_AnimatorICA;


		public void LoadFailSafePheromosa_AnimatorController()
		{
			LoadFailSafePheromosa_ConvertToAnimatorController();
			LoadFailSafePheromosa_MovementAnimatorController();
			LoadFailSafePheromosa_IdleAnimatorController();
		}
		private void LoadFailSafePheromosa_ConvertToAnimatorController()
		{
			LFSPheromosa_AnimatorCCA.PHCoverterToAnimatorController();
		}
		private void LoadFailSafePheromosa_MovementAnimatorController()
		{
			LFSPheromosa_AnimatorCMA.PHMovementAnimatorController();
		}
		private void LoadFailSafePheromosa_IdleAnimatorController()
		{
			LFSPheromosa_AnimatorICA.PH_IdleAnimatorController();
		}
	}
}
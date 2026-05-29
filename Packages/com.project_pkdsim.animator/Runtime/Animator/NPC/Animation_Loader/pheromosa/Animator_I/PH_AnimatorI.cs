using project_pkdsim.ANIMATOR.NPC.Pheromosa.idlebaseanimation;
using project_pkdsim.ANIMATOR.NPC.Pheromosa.movementbasedanimations;
using project_pkdsim.ANIMATOR.NPC.Pheromosa.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Pheromosa.Animator_I
{
	public class LFS_PheromosaFailSafe : MonoBehaviour 
	{
		public Animator Pheromosa_Animator;
		public RuntimeAnimatorController someController;

		private Pheromosa_ConverterToAnimatorController LFSPheromosa_AnimatorCCA;
		private Pheromosa_AnimatorMovementController LFSPheromosa_AnimatorCMA;
		private Pheromosa_IdleAnimatorController LFSPheromosa_AnimatorICA;


		public void LoadFailSafePheromosa_AnimatorController()
		{
			LoadFailSafePheromosa_ConvertToAnimatorController();
			LoadFailSafePheromosa_MovementAnimatorController();
			LoadFailSafePheromosa_IdleAnimatorController();
		}
		private void LoadFailSafePheromosa_ConvertToAnimatorController()
		{
			LFSPheromosa_AnimatorCCA.PH_ConverterToAnimatorController();
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
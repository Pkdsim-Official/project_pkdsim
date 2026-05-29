using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.idlebaseanimation;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.movementbasedanimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.converteranimations;
using project_pkdsim.Generics.NPC.Species.Type;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.Animator_I
{
	public class LFS_PheromosaFailSafe : MonoBehaviour 
	{
		public Animator Pheromosa_Animator;
		public RuntimeAnimatorController someController;

		private NPCSpeciesType pheromosa = NPCSpeciesType.PHEROMOSA;

		private Pheromosa_LFS_ConverterToAnimatorController LFSPheromosa_AnimatorCCA;
		private Pheromosa_LFS_AnimatorMovementController LFSPheromosa_AnimatorCMA;
		private Pheromosa_LFS_IdleAnimatorController LFSPheromosa_AnimatorICA;


		public void LoadFailSafePheromosa_AnimatorController()
		{
			LoadFailSafePheromosa_ConvertToAnimatorController();
			LoadFailSafePheromosa_MovementAnimatorController();
			LoadFailSafePheromosa_IdleAnimatorController();
		}
		private void LoadFailSafePheromosa_ConvertToAnimatorController()
		{
			LFSPheromosa_AnimatorCCA.PH_LFS_ConverterToAnimatorController();
		}
		private void LoadFailSafePheromosa_MovementAnimatorController()
		{
			LFSPheromosa_AnimatorCMA.PH_LFS_MovementAnimatorController();
		}
		private void LoadFailSafePheromosa_IdleAnimatorController()
		{
			LFSPheromosa_AnimatorICA.PH_LFS_IdleAnimatorController();
		}
	}
}
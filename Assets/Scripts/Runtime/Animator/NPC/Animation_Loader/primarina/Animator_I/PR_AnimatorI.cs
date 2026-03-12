using Project_Pkdsim.ANIMATOR.Npcs.Primarina.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Npcs.Primarina.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Npcs.Primarina.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Primarina.Animator_I
{
	public class LFS_PrimarinaFailSafe : MonoBehaviour 
	{
		public Animator Primarina_Animator;
		public RuntimeAnimatorController someController;

		private PrimarinaCoverterAnimatorController LFSPrimarina_AnimatorCCA;
		private Primarina_MovementAnimatorController LFSPrimarina_AnimatorCMA;
		private Primarina_IdleAnimatorController LFSPrimarina_AnimatorICA;


		public void LoadFailSafePrimarina_AnimatorController()
		{
			LoadFailSafePrimarina_ConvertToAnimatorController();
			LoadFailSafePrimarina_MovementAnimatorController();
			LoadFailSafePrimarina_IdleAnimatorController();
		}
		private void LoadFailSafePrimarina_ConvertToAnimatorController()
		{
			LFSPrimarina_AnimatorCCA.PRCoverterToAnimatorController();
		}
		private void LoadFailSafePrimarina_MovementAnimatorController()
		{
			LFSPrimarina_AnimatorCMA.PRMovementAnimatorController();
		}
		private void LoadFailSafePrimarina_IdleAnimatorController()
		{
			LFSPrimarina_AnimatorICA.PR_IdleAnimatorController();
		}
	}
}
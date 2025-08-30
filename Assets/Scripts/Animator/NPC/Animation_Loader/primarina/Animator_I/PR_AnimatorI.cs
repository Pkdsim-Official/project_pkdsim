using project_pkdsim.Models.ANIMATOR.NPC.Primarina.idlebaseanimation;
using project_pkdsim.Models.ANIMATOR.NPC.Primarina.movementbasedanimations;
using project_pkdsim.Models.ANIMATOR.NPC.Primarina.converteranimations;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Primarina.Animator_I
{
	public class LFS_PrimarinaFailSafe : MonoBehaviour 
	{
		public Animator Primarina_Animator;
		public RuntimeAnimatorController someController;

		private PrimarinaCoverterAnimatorController LFSPrimarina_AnimatorCCA;
		private Primarina_AnimatorBaseMovementController LFSPrimarina_AnimatorCMA;
		private PrimarinaIdleAnimatorController LFSPrimarina_AnimatorICA;


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
			LFSPrimarina_AnimatorICA.PRIdleAnimatorController();
		}
	}
}
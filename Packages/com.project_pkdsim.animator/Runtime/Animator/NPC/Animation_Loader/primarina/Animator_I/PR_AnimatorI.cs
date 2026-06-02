using project_pkdsim.ANIMATOR.NPC.Primarina.idlebaseanimation;
using project_pkdsim.ANIMATOR.NPC.Primarina.movementbasedanimations;
using project_pkdsim.ANIMATOR.NPC.Primarina.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Primarina.Animator_I
{
	public class LFS_PrimarinaFailSafe : MonoBehaviour 
	{
		public Animator Primarina_Animator;
		public RuntimeAnimatorController someController;

		private Primarina_ConverterAnimatorController LFSPrimarina_AnimatorCCA;
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
			LFSPrimarina_AnimatorCCA.PR_ConverterAnimatorController();
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
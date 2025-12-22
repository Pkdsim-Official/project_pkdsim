using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.idlebaseanimation;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.movementbasedanimations;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.converteranimations;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Animator_I
{
	public class LFS_PrimarinaFailSafe : MonoBehaviour 
	{
		public Animator PrimarinaParentDad_Animator;
		public RuntimeAnimatorController someController;

		private PrimarinaConverterAnimatorController LFSPrimarina_AnimatorCCA;
		private PrimarinaParentDad_MovementAnimatorController LFSPrimarina_AnimatorCMA;
		private Primarina_IdleAnimatorController LFSPrimarina_AnimatorICA;


		public void LoadFailSafePrimarina_AnimatorController()
		{
			LoadFailSafePrimarina_ConvertToAnimatorController();
			LoadFailSafePrimarina_MovementAnimatorController();
			LoadFailSafePrimarina_IdleAnimatorController();
		}
		private void LoadFailSafePrimarina_ConvertToAnimatorController()
		{
			LFSPrimarina_AnimatorCCA.PRConverterAnimatorController();
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
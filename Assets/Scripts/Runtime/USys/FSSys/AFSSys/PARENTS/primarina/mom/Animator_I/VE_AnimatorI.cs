using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.idlebaseanimation;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.movementbasedanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.Animator_I
{
	public class LFS_VespiquenFailSafe : MonoBehaviour 
	{
		public Animator PrimarinaParentMom_Animator;
		public RuntimeAnimatorController someController;

		private PrimarinaParentMom_ConverterAnimatorController LFSPrimarina_AnimatorCCA;
		private PrimarinaParentMom_MovementAnimatorController LFSPrimarina_AnimatorCMA;
		private PrimarinaParentMom_IdleAnimatorController LFSPrimarina_AnimatorICA;


		public void LoadFailSafePrimarina_AnimatorController()
		{
			LoadFailSafeVespiquen_ConvertToAnimatorController();
			LoadFailSafeVespiquen_MovementAnimatorController();
			LoadFailSafeVespiquen_IdleAnimatorController();
		}
		private void LoadFailSafeVespiquen_ConvertToAnimatorController()
		{
			LFSPrimarina_AnimatorCCA.PRParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeVespiquen_MovementAnimatorController()
		{
			LFSPrimarina_AnimatorCMA.PRParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeVespiquen_IdleAnimatorController()
		{
			LFSPrimarina_AnimatorICA.PRParentMom_IdleAnimatorController();
		}
	}
}
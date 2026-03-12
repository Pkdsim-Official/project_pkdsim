using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.idlebaseanimation;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.movementbasedanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.Animator_I
{
	public class LFS_GardevoirFailSafe : MonoBehaviour 
	{
		public Animator GardevoirParentMom_Animator;
		public RuntimeAnimatorController someController;

		private GardevoirParentMom_ConverterAnimatorController LFSGardevoir_AnimatorCCA;
		private GardevoirParentMom_MovementAnimatorController LFSGardevoir_AnimatorCMA;
		private GardevoirParentMom_IdleAnimatorController LFSGardevoir_AnimatorICA;


		public void LoadFailSafeGardevoir_AnimatorController()
		{
			LoadFailSafeGardevoir_ConvertToAnimatorController();
			LoadFailSafeGardevoir_MovementAnimatorController();
			LoadFailSafeGardevoir_IdleAnimatorController();
		}
		private void LoadFailSafeGardevoir_ConvertToAnimatorController()
		{
			LFSGardevoir_AnimatorCCA.GARDParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeGardevoir_MovementAnimatorController()
		{
			LFSGardevoir_AnimatorCMA.GARDParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeGardevoir_IdleAnimatorController()
		{
			LFSGardevoir_AnimatorICA.GARDParentMom_IdleAnimatorController();
		}
	}
}
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.idlebaseanimation;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.movementbasedanimations;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.Animator_I
{
	public class LFS_ZoroarkFailSafe : MonoBehaviour 
	{
		public Animator ZoroarkParentMom_Animator;
		public RuntimeAnimatorController someController;

		private ZoroarkParentMom_ConverterAnimatorController LFSZoroark_AnimatorCCA;
		private ZoroarkParentMom_MovementAnimatorController LFSZoroark_AnimatorCMA;
		private ZoroarkParentMom_IdleAnimatorController LFSZoroark_AnimatorICA;


		public void LoadFailSafeZoroark_AnimatorController()
		{
			LoadFailSafeZoroark_ConvertToAnimatorController();
			LoadFailSafeZoroark_MovementAnimatorController();
			LoadFailSafeZoroark_IdleAnimatorController();
		}
		private void LoadFailSafeZoroark_ConvertToAnimatorController()
		{
			LFSZoroark_AnimatorCCA.ZParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeZoroark_MovementAnimatorController()
		{
			LFSZoroark_AnimatorCMA.ZParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeZoroark_IdleAnimatorController()
		{
			LFSZoroark_AnimatorICA.ZParentMom_IdleAnimatorController();
		}
	}
}
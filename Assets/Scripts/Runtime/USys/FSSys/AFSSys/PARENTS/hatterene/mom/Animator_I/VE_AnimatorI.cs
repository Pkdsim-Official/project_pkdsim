using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.idlebaseanimation;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.movementbasedanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Animator_I
{
	public class LFS_HattereneFailSafe : MonoBehaviour 
	{
		public Animator HattereneParentMom_Animator;
		public RuntimeAnimatorController someController;

		private HattereneParentMom_ConverterAnimatorController LFSHatterene_AnimatorCCA;
		private HattereneParentMom_MovementAnimatorController LFSHatterene_AnimatorCMA;
		private HattereneParentMom_IdleAnimatorController LFSHatterene_AnimatorICA;


		public void LoadFailSafeHatterene_AnimatorController()
		{
			LoadFailSafeHatterene_ConvertToAnimatorController();
			LoadFailSafeHatterene_MovementAnimatorController();
			LoadFailSafeHatterene_IdleAnimatorController();
		}
		private void LoadFailSafeHatterene_ConvertToAnimatorController()
		{
			LFSHatterene_AnimatorCCA.HATParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeHatterene_MovementAnimatorController()
		{
			LFSHatterene_AnimatorCMA.HATParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeHatterene_IdleAnimatorController()
		{
			LFSHatterene_AnimatorICA.HATParentMom_IdleAnimatorController();
		}
	}
}
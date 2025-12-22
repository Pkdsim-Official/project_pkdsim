using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Dad.idlebaseanimation;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Dad.movementbasedanimations;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Dad.converteranimations;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Dad.Animator_I
{
	public class LFS_BraixenParentDadFailSafe : MonoBehaviour 
	{
		public Animator BraixenParentDad_Animator;
		public RuntimeAnimatorController someController;

		private BraixenParentDad_ConverterAnimatorController LFSBraixen_AnimatorCCA;
		private BraixenParentDad_MovementAnimatorController LFSBraixen_AnimatorCMA;
		private BraixenParentDad_IdleAnimatorController LFSBraixen_AnimatorICA;


		public void LoadFailSafeBraixen_AnimatorController()
		{
			LoadFailSafeBraixen_ConvertToAnimatorController();
			LoadFailSafeBraixen_MovementAnimatorController();
			LoadFailSafeBraixen_IdleAnimatorController();
		}
		private void LoadFailSafeBraixen_ConvertToAnimatorController()
		{
			LFSBraixen_AnimatorCCA.BRConverterAnimatorController();
		}
		private void LoadFailSafeBraixen_MovementAnimatorController()
		{
			LFSBraixen_AnimatorCMA.BRMovementAnimatorController();
		}
		private void LoadFailSafeBraixen_IdleAnimatorController()
		{
			LFSBraixen_AnimatorICA.BRParentDad_IdleAnimatorController();
		}
	}
}
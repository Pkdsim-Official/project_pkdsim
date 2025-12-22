using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.idlebaseanimation;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.movementbasedanimations;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.Animator_I
{
	public class LFS_VespiquenFailSafe : MonoBehaviour 
	{
		public Animator VespiquenParentDad_Animator;
		public RuntimeAnimatorController someController;

		private VespiquenParentDad_ConverterAnimatorController LFSVespiquen_AnimatorCCA;
		private VespiquenParentDad_MovementAnimatorController LFSVespiquen_AnimatorCMA;
		private VespiquenParentDad_IdleAnimatorController LFSVespiquen_AnimatorICA;


		public void LoadFailSafeVespiquen_AnimatorController()
		{
			LoadFailSafeVespiquen_ConvertToAnimatorController();
			LoadFailSafeVespiquen_MovementAnimatorController();
			LoadFailSafeVespiquen_IdleAnimatorController();
		}
		private void LoadFailSafeVespiquen_ConvertToAnimatorController()
		{
			LFSVespiquen_AnimatorCCA.VEParentDad_ConverterAnimatorController();
		}
		private void LoadFailSafeVespiquen_MovementAnimatorController()
		{
			LFSVespiquen_AnimatorCMA.VEParentDad_MovementAnimatorController();
		}
		private void LoadFailSafeVespiquen_IdleAnimatorController()
		{
			LFSVespiquen_AnimatorICA.VEParentDad_IdleAnimatorController();
		}
	}
}
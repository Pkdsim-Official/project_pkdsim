using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.idlebaseanimation;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.Animator_I
{
	public class LFS_VespiquenFailSafe : MonoBehaviour
	{
		public Animator LunalaParentMom_Animator;
		public RuntimeAnimatorController someController;

		private LunalaParentMom_ConverterAnimatorController LFSLunala_AnimatorCCA;
		private LunalaParentMom_MovementAnimatorController LFSLunala_AnimatorCMA;
		private LunalaParentMom_IdleAnimatorController LFSLunala_AnimatorICA;


		public void LoadFailSafeLunala_AnimatorController()
		{
			LoadFailSafeVespiquen_ConvertToAnimatorController();
			LoadFailSafeVespiquen_MovementAnimatorController();
			LoadFailSafeVespiquen_IdleAnimatorController();
		}
		private void LoadFailSafeVespiquen_ConvertToAnimatorController()
		{
			LFSLunala_AnimatorCCA.LUNAParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeVespiquen_MovementAnimatorController()
		{
			LFSLunala_AnimatorCMA.LUNAParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeVespiquen_IdleAnimatorController()
		{
			LFSLunala_AnimatorICA.LUNAParentMom_IdleAnimatorController();
		}
	}
}
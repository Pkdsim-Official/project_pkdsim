using project_pkdsim.ANIMATOR.Parents.Lunala.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Lunala.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Lunala.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lunala.Animator_I
{
	public class LFS_LunalaFailSafe : MonoBehaviour 
	{
		public Animator LunalaParentDad_Animator;
		public RuntimeAnimatorController someController;

		private LunalaConverterAnimatorController LFSLunala_AnimatorCCA;
		private LunalaParentDad_MovementAnimatorController LFSLunala_AnimatorCMA;
		private Lunala_IdleAnimatorController LFSLunala_AnimatorICA;


		public void LoadFailSafeLunala_AnimatorController()
		{
			LoadFailSafeLunala_ConvertToAnimatorController();
			LoadFailSafeLunala_MovementAnimatorController();
			LoadFailSafeLunala_IdleAnimatorController();
		}
		private void LoadFailSafeLunala_ConvertToAnimatorController()
		{
			LFSLunala_AnimatorCCA.LUNAConverterAnimatorController();
		}
		private void LoadFailSafeLunala_MovementAnimatorController()
		{
			LFSLunala_AnimatorCMA.LUNAMovementAnimatorController();
		}
		private void LoadFailSafeLunala_IdleAnimatorController()
		{
			LFSLunala_AnimatorICA.LUNA_IdleAnimatorController();
		}
	}
}
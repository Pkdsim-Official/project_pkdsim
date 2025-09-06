using project_pkdsim.ANIMATOR.NPC.Lunala.idlebaseanimation;
using project_pkdsim.ANIMATOR.NPC.Lunala.movementbasedanimations;
using project_pkdsim.ANIMATOR.NPC.Lunala.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Lunala.Animator_I
{
	public class LFS_LunalaFailSafe : MonoBehaviour 
	{
		public Animator Lunala_Animator;
		public RuntimeAnimatorController someController;

		private LunalaCoverterAnimatorController LFSLunala_AnimatorCCA;
		private Lunala_AnimatorBaseMovementController LFSLunala_AnimatorCMA;
		private LunalaIdleAnimatorController LFSLunala_AnimatorICA;


		public void LoadFailSafeLunala_AnimatorController()
		{
			LoadFailSafeLunala_ConvertToAnimatorController();
			LoadFailSafeLunala_MovementAnimatorController();
			LoadFailSafeLunala_IdleAnimatorController();
		}
		private void LoadFailSafeLunala_ConvertToAnimatorController()
		{
			LFSLunala_AnimatorCCA.LUNACoverterToAnimatorController();
		}
		private void LoadFailSafeLunala_MovementAnimatorController()
		{
			LFSLunala_AnimatorCMA.LUNAMovementAnimatorController();
		}
		private void LoadFailSafeLunala_IdleAnimatorController()
		{
			LFSLunala_AnimatorICA.LUNAIdleAnimatorController();
		}
	}
}
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.idlebaseanimation;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.movementbasedanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.Animator_I
{
	public class LFS_FrostlassFailSafe : MonoBehaviour 
	{
		public Animator Frostlass_Animator;
		public RuntimeAnimatorController someController;

		private Frostlass_LFS_CoverterAnimatorController LFSFrostlass_AnimatorCCA;
		private Frostlass_LFS_MovementAnimatorController LFSFrostlass_AnimatorCMA;
		private Frostlass_LFS_IdleAnimatorController LFSFrostlass_AnimatorICA;


		public void LoadFailSafeFrostlass_AnimatorController()
		{
			LoadFailSafeFrostlass_ConvertToAnimatorController();
			LoadFailSafeFrostlass_MovementAnimatorController();
			LoadFailSafeFrostlass_IdleAnimatorController();
		}
		private void LoadFailSafeFrostlass_ConvertToAnimatorController()
		{
			LFSFrostlass_AnimatorCCA.FR_LFS_CoverterToAnimatorController();
		}
		private void LoadFailSafeFrostlass_MovementAnimatorController()
		{
			LFSFrostlass_AnimatorCMA.FR_LFS_MovementAnimatorController();
		}
		private void LoadFailSafeFrostlass_IdleAnimatorController()
		{
			LFSFrostlass_AnimatorICA.FR_LFS_IdleAnimatorController();
		}
	}
}
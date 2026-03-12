using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.converteranimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.idlebaseanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.movementbasedanimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.Animator_I
{
	public class LFS_UmbreonFailSafe : MonoBehaviour 
	{		
		public Animator Umbreon_Animator;
		public RuntimeAnimatorController someController;

		private Umbreon_LFS_AnimatorCoverterController LFSUmbreon_AnimatorCCA;
		private Umbreon_LFS_MovementAnimatorController LFSUmbreon_AnimatorCMA;
		private Umbreon_LFS_AnimatorBaseIdleController LFSUmbreon_AnimatorICA;

		public void LoadFailSafeUmbreon_AnimatorController()
		{
			LoadFailSafeUmbreon_ConvertToAnimatorController();
			LoadFailSafeUmbreon_IdleAnimatorController();
			LoadFailSafeUmbreon_MovementAnimatorController();
		}
		private void LoadFailSafeUmbreon_ConvertToAnimatorController()
		{
			LFSUmbreon_AnimatorCCA.UM_LFS_ConverterAnimatorController();
		}
		private void LoadFailSafeUmbreon_MovementAnimatorController()
		{
			LFSUmbreon_AnimatorCMA.UM_LFS_MovementAnimatorController();
		}
		private void LoadFailSafeUmbreon_IdleAnimatorController()
		{
			LFSUmbreon_AnimatorICA.UM_LFS_IdleAnimatorController();
		}
	}
}
using project_pkdsim.ANIMATOR.Npcs.Delphox.idlebaseanimation;
using project_pkdsim.ANIMATOR.Npcs.Delphox.movementbasedanimations;
using project_pkdsim.ANIMATOR.Npcs.Delphox.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Delphox.Animator_I
{
	public class LFS_DelphoxFailSafe : MonoBehaviour 
	{
		public Animator Delphox_Animator;
		public RuntimeAnimatorController someController;

		private DelphoxCoverterAnimatorController LFSDelphox_AnimatorCCA;
		private Delphox_MovementAnimatorController LFSDelphox_AnimatorCMA;
		private Delphox_IdleAnimatorController LFSDelphox_AnimatorICA;


		public void LoadFailSafeDelphox_AnimatorController()
		{
			LoadFailSafeDelphox_ConvertToAnimatorController();
			LoadFailSafeDelphox_MovementAnimatorController();
			LoadFailSafeDelphox_IdleAnimatorController();
		}
		private void LoadFailSafeDelphox_ConvertToAnimatorController()
		{
			LFSDelphox_AnimatorCCA.DLCoverterToAnimatorController();
		}
		private void LoadFailSafeDelphox_MovementAnimatorController()
		{
			LFSDelphox_AnimatorCMA.DLMovementAnimatorController();
		}
		private void LoadFailSafeDelphox_IdleAnimatorController()
		{
			LFSDelphox_AnimatorICA.DL_IdleAnimatorController();
		}
	}
}
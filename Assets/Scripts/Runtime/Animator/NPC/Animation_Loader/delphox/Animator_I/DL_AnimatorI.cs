using Project_Pkdsim.ANIMATOR.Npcs.Delphox.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Npcs.Delphox.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Npcs.Delphox.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Delphox.Animator_I
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
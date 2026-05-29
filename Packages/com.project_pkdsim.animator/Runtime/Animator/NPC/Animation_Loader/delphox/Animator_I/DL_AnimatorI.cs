using project_pkdsim.ANIMATOR.NPC.Delphox.idlebaseanimation;
using project_pkdsim.ANIMATOR.NPC.Delphox.movementbasedanimations;
using project_pkdsim.ANIMATOR.NPC.Delphox.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Delphox.Animator_I
{
	public class LFS_DelphoxFailSafe : MonoBehaviour 
	{
		public Animator Delphox_Animator;
		public RuntimeAnimatorController someController;

		private Delphox_ConverterToAnimatorController LFSDelphox_AnimatorCCA;
		private Delphox_AnimatorMovementController LFSDelphox_AnimatorCMA;
		private Delphox_IdleAnimatorController LFSDelphox_AnimatorICA;


		public void LoadFailSafeDelphox_AnimatorController()
		{
			LoadFailSafeDelphox_ConvertToAnimatorController();
			LoadFailSafeDelphox_MovementAnimatorController();
			LoadFailSafeDelphox_IdleAnimatorController();
		}
		private void LoadFailSafeDelphox_ConvertToAnimatorController()
		{
			LFSDelphox_AnimatorCCA.DL_ConverterToAnimatorController();
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
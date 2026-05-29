using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.idlebaseanimation;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.movementbasedanimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.converteranimations;
using project_pkdsim.Generics.NPC.Species.Type;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.Animator_I
{
	public class LFS_DelphoxFailSafe : MonoBehaviour 
	{
		public Animator Delphox_Animator;
		public RuntimeAnimatorController someController;

		private NPCSpeciesType delphox = NPCSpeciesType.DELPHOX;

		private Delphox_LFS_ConverterToAnimatorController LFSDelphox_AnimatorCCA;
		private Delphox_LFS_AnimatorMovementController LFSDelphox_AnimatorCMA;
		private Delphox_LFS_IdleAnimatorController LFSDelphox_AnimatorICA;


		public void LoadFailSafeDelphox_AnimatorController()
		{
			LoadFailSafeDelphox_ConvertToAnimatorController();
			LoadFailSafeDelphox_MovementAnimatorController();
			LoadFailSafeDelphox_IdleAnimatorController();
		}
		private void LoadFailSafeDelphox_ConvertToAnimatorController()
		{
			LFSDelphox_AnimatorCCA.DL_LFS_ConverterToAnimatorController();
		}
		private void LoadFailSafeDelphox_MovementAnimatorController()
		{
			LFSDelphox_AnimatorCMA.DL_LFS_MovementAnimatorController();
		}
		private void LoadFailSafeDelphox_IdleAnimatorController()
		{
			LFSDelphox_AnimatorICA.DL_LFS_IdleAnimatorController();
		}
	}
}
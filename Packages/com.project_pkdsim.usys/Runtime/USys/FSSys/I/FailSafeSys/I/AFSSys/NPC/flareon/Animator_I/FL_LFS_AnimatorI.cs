using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.idlebaseanimation;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.movementbasedanimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.converteranimations;
using project_pkdsim.Generics.NPC.Species.Type;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.Animator_I
{
	public class LFS_FlareonFailSafe : MonoBehaviour 
	{
		public Animator Flareon_Animator;
		public RuntimeAnimatorController someController;

		private NPCSpeciesType flareon = NPCSpeciesType.FLAREON;

		private Flareon_LFS_ConverterAnimatorController LFSFlareon_AnimatorCCA;
		private Flareon_LFS_MovementAnimatorController LFSFlareon_AnimatorCMA;
		private Flareon_LFS_IdleAnimatorController LFSFlareon_AnimatorICA;


		public void LoadFailSafeFlareon_AnimatorController()
		{
			LoadFailSafeFlareon_ConvertToAnimatorController();
			LoadFailSafeFlareon_MovementAnimatorController();
			LoadFailSafeFlareon_IdleAnimatorController();
		}
		private void LoadFailSafeFlareon_ConvertToAnimatorController()
		{
			LFSFlareon_AnimatorCCA.FL_LFS_ConverterAnimatorController();
		}
		private void LoadFailSafeFlareon_MovementAnimatorController()
		{
			LFSFlareon_AnimatorCMA.FL_LFS_MovementAnimatorController();
		}
		private void LoadFailSafeFlareon_IdleAnimatorController()
		{
			LFSFlareon_AnimatorICA.FL_LFS_IdleAnimatorController();
		}
	}
}

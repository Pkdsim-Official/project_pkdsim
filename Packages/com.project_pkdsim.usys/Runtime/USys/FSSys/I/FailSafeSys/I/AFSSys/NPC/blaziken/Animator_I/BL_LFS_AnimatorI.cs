using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.idlebaseanimation;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.movementbasedanimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.converteranimations;
using project_pkdsim.Generics.NPC.Species.Type;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.Animator_I
{
	public class LFS_BlazikenFailSafe : MonoBehaviour 
	{
		public Animator Blaziken_Animator;
		public RuntimeAnimatorController someController;

		private NPCSpeciesType blaziken = NPCSpeciesType.BLAZIKEN;

		private Blaziken_LFS_ConverterToAnimatorController LFSBlaziken_AnimatorCCA;
		private Blaziken_LFS_AnimatorMovementController LFSBlaziken_AnimatorCMA;
		private Blaziken_LFS_IdleAnimatorController LFSBlaziken_AnimatorICA;


		public void LoadFailSafeBlaziken_AnimatorController()
		{
			LoadFailSafeBlaziken_ConvertToAnimatorController();
			LoadFailSafeBlaziken_MovementAnimatorController();
			LoadFailSafeBlaziken_IdleAnimatorController();
		}
		private void LoadFailSafeBlaziken_ConvertToAnimatorController()
		{
			LFSBlaziken_AnimatorCCA.BL_LFS_ConverterToAnimatorController();
		}
		private void LoadFailSafeBlaziken_MovementAnimatorController()
		{
			LFSBlaziken_AnimatorCMA.BL_LFS_MovementAnimatorController();
		}
		private void LoadFailSafeBlaziken_IdleAnimatorController()
		{
			LFSBlaziken_AnimatorICA.BL_LFS_IdleAnimatorController();
		}
	}
}
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.idlebaseanimation;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.movementbasedanimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.converteranimations;
using project_pkdsim.Generics.NPC.Species.Type;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.Animator_I
{
	public class LFS_CinderaceFailSafe : MonoBehaviour 
	{
		public Animator Cinderace_Animator;
		public RuntimeAnimatorController someController;

		private NPCSpeciesType cinderace = NPCSpeciesType.CINDERACE;

		private Cinderace_LFS_ConverterToAnimatorController LFSCinderace_AnimatorCCA;
		private Cinderace_LFS_AnimatorMovementController LFSCinderace_AnimatorCMA;
		private Cinderace_LFS_IdleAnimatorController LFSCinderace_AnimatorICA;


		public void LoadFailSafeCinderace_AnimatorController()
		{
			LoadFailSafeCinderace_ConvertToAnimatorController();
			LoadFailSafeCinderace_MovementAnimatorController();
			LoadFailSafeCinderace_IdleAnimatorController();
		}
		private void LoadFailSafeCinderace_ConvertToAnimatorController()
		{
			LFSCinderace_AnimatorCCA.C_LFS_ConverterToAnimatorController();
		}
		private void LoadFailSafeCinderace_MovementAnimatorController()
		{
			LFSCinderace_AnimatorCMA.C_LFS_MovementAnimatorController();
		}
		private void LoadFailSafeCinderace_IdleAnimatorController()
		{
			LFSCinderace_AnimatorICA.C_LFS_IdleAnimatorController();
		}
	}
}
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.idlebaseanimation;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.movementbasedanimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.converteranimations;
using project_pkdsim.Generics.NPC.Species.Type;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.Animator_I
{
	public class LFS_LunalaFailSafe : MonoBehaviour 
	{
		public Animator Lunala_Animator;
		public RuntimeAnimatorController someController;

		private NPCSpeciesType lunala = NPCSpeciesType.LUNALA;

		private Lunala_LFS_ConverterToAnimatorController LFSLunala_AnimatorCCA;
		private Lunala_LFS_AnimatorMovementController LFSLunala_AnimatorCMA;
		private Lunala_LFS_IdleAnimatorController LFSLunala_AnimatorICA;


		public void LoadFailSafeLunala_AnimatorController()
		{
			LoadFailSafeLunala_ConvertToAnimatorController();
			LoadFailSafeLunala_MovementAnimatorController();
			LoadFailSafeLunala_IdleAnimatorController();
		}
		private void LoadFailSafeLunala_ConvertToAnimatorController()
		{
			LFSLunala_AnimatorCCA.LUNA_LFS_ConverterToAnimatorController();
		}
		private void LoadFailSafeLunala_MovementAnimatorController()
		{
			LFSLunala_AnimatorCMA.LUNA_LFS_MovementAnimatorController();
		}
		private void LoadFailSafeLunala_IdleAnimatorController()
		{
			LFSLunala_AnimatorICA.LUNA_LFS_IdleAnimatorController();
		}
	}
}
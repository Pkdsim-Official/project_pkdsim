using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.idlebaseanimation;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.movementbasedanimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.converteranimations;
using project_pkdsim.Generics.NPC.Species.Type;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.Animator_I
{
	public class LFS_AbsolFailSafe : MonoBehaviour 
	{
		public Animator Absol_Animator;
		public RuntimeAnimatorController someController;

		private NPCSpeciesType absol = NPCSpeciesType.ABSOL;

		private Absol_LFS_ConverterAnimatorController LFSAbsol_AnimatorCCA;
		private Absol_LFS_MovementAnimatorController LFSAbsol_AnimatorCMA;
		private Absol_LFS_IdleAnimatorController LFSAbsol_AnimatorICA;


		public void LoadFailSafeAbsol_AnimatorController()
		{
			LoadFailSafeAbsol_ConvertToAnimatorController();
			LoadFailSafeAbsol_MovementAnimatorController();
			LoadFailSafeAbsol_IdleAnimatorController();
		}
		private void LoadFailSafeAbsol_ConvertToAnimatorController()
		{
			LFSAbsol_AnimatorCCA.AB_LFS_ConverterAnimatorController();
		}
		private void LoadFailSafeAbsol_MovementAnimatorController()
		{
			LFSAbsol_AnimatorCMA.AB_LFS_MovementAnimatorController();
		}
		private void LoadFailSafeAbsol_IdleAnimatorController()
		{
			LFSAbsol_AnimatorICA.AB_LFS_IdleAnimatorController();
		}
	}
}
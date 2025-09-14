using project_pkdsim.ANIMATOR.Npcs.Absol.idlebaseanimation;
using project_pkdsim.ANIMATOR.Npcs.Absol.movementbasedanimations;
using project_pkdsim.ANIMATOR.Npcs.Absol.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Absol.Animator_I
{
	public class LFS_AbsolFailSafe : MonoBehaviour 
	{
		public Animator Absol_Animator;
		public RuntimeAnimatorController someController;

		private Absol_CoverterAnimatorController LFSAbsol_AnimatorCCA;
		private Absol_MovementAnimatorController LFSAbsol_AnimatorCMA;
		private Absol_IdleAnimatorController LFSAbsol_AnimatorICA;


		public void LoadFailSafeAbsol_AnimatorController()
		{
			LoadFailSafeAbsol_ConvertToAnimatorController();
			LoadFailSafeAbsol_MovementAnimatorController();
			LoadFailSafeAbsol_IdleAnimatorController();
		}
		private void LoadFailSafeAbsol_ConvertToAnimatorController()
		{
			LFSAbsol_AnimatorCCA.AB_CoverterToAnimatorController();
		}
		private void LoadFailSafeAbsol_MovementAnimatorController()
		{
			LFSAbsol_AnimatorCMA.AB_MovementAnimatorController();
		}
		private void LoadFailSafeAbsol_IdleAnimatorController()
		{
			LFSAbsol_AnimatorICA.AB_IdleAnimatorController();
		}
	}
}
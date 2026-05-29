using project_pkdsim.ANIMATOR.NPC.Absol.idlebaseanimation;
using project_pkdsim.ANIMATOR.NPC.Absol.movementbasedanimations;
using project_pkdsim.ANIMATOR.NPC.Absol.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Absol.Animator_I
{
	public class LFS_AbsolFailSafe : MonoBehaviour 
	{
		public Animator Absol_Animator;
		public RuntimeAnimatorController someController;

		private Absol_ConverterToAnimatorController LFSAbsol_AnimatorCCA;
		private Absol_AnimatorMovementController LFSAbsol_AnimatorCMA;
		private Absol_IdleAnimatorController LFSAbsol_AnimatorICA;


		public void LoadFailSafeAbsol_AnimatorController()
		{
			LoadFailSafeAbsol_ConvertToAnimatorController();
			LoadFailSafeAbsol_MovementAnimatorController();
			LoadFailSafeAbsol_IdleAnimatorController();
		}
		private void LoadFailSafeAbsol_ConvertToAnimatorController()
		{
			LFSAbsol_AnimatorCCA.AB_ConverterToAnimatorController();
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
using project_pkdsim.ANIMATOR.Parents.Absol.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Absol.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Absol.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Absol.Animator_I
{
	public class LFS_AbsolFailSafe : MonoBehaviour 
	{
		public Animator Absol_Animator;
		public RuntimeAnimatorController someController;

		private AbsolConverterAnimatorController LFSAbsol_AnimatorCCA;
		private AbsolParent_AnimatorBaseMovementController LFSAbsol_AnimatorCMA;
		private Absol_IdleAnimatorController LFSAbsol_AnimatorICA;


		public void LoadFailSafeAbsol_AnimatorController()
		{
			LoadFailSafeAbsol_ConvertToAnimatorController();
			LoadFailSafeAbsol_MovementAnimatorController();
			LoadFailSafeAbsol_IdleAnimatorController();
		}
		private void LoadFailSafeAbsol_ConvertToAnimatorController()
		{
			LFSAbsol_AnimatorCCA.ABConverterToAnimatorController();
		}
		private void LoadFailSafeAbsol_MovementAnimatorController()
		{
			LFSAbsol_AnimatorCMA.ABMovementAnimatorController();
		}
		private void LoadFailSafeAbsol_IdleAnimatorController()
		{
			LFSAbsol_AnimatorICA.AB_IdleAnimatorController();
		}
	}
}
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.idlebaseanimation;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.movementbasedanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.Animator_I
{
	public class LFS_AbsolFailSafe : MonoBehaviour 
	{
		public Animator AbsolParentDad_Animator;
		public RuntimeAnimatorController someController;

		private AbsolConverterAnimatorController LFSAbsol_AnimatorCCA;
		private AbsolParentDad_MovementAnimatorController LFSAbsol_AnimatorCMA;
		private Absol_IdleAnimatorController LFSAbsol_AnimatorICA;


		public void LoadFailSafeAbsol_AnimatorController()
		{
			LoadFailSafeAbsol_ConvertToAnimatorController();
			LoadFailSafeAbsol_MovementAnimatorController();
			LoadFailSafeAbsol_IdleAnimatorController();
		}
		private void LoadFailSafeAbsol_ConvertToAnimatorController()
		{
			LFSAbsol_AnimatorCCA.ABConverterAnimatorController();
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
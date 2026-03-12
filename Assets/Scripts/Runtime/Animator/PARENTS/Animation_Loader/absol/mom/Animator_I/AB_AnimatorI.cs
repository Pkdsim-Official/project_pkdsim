using Project_Pkdsim.ANIMATOR.Parents.Absol.Mom.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Parents.Absol.Mom.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Parents.Absol.Mom.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Absol.Mom.Animator_I
{
	public class LFS_AbsolFailSafe : MonoBehaviour
	{
		public Animator AbsolParentMom_Animator;
		public RuntimeAnimatorController someController;

		private AbsolParentMom_ConverterAnimatorController LFSAbsol_AnimatorCCA;
		private AbsolParentMom_MovementAnimatorController LFSAbsol_AnimatorCMA;
		private AbsolParentMom_IdleAnimatorController LFSAbsol_AnimatorICA;


		public void LoadFailSafeAbsol_AnimatorController()
		{
			LoadFailSafeAbsol_ConvertToAnimatorController();
			LoadFailSafeAbsol_MovementAnimatorController();
			LoadFailSafeAbsol_IdleAnimatorController();
		}
		private void LoadFailSafeAbsol_ConvertToAnimatorController()
		{
			LFSAbsol_AnimatorCCA.ABParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeAbsol_MovementAnimatorController()
		{
			LFSAbsol_AnimatorCMA.ABParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeAbsol_IdleAnimatorController()
		{
			LFSAbsol_AnimatorICA.ABParentMom_IdleAnimatorController();
		}
	}
}
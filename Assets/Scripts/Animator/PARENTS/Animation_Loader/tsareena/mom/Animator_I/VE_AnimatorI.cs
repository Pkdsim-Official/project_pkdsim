using project_pkdsim.ANIMATOR.Parents.Vespiquen.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Animator_I
{
	public class LFS_VespiquenFailSafe : MonoBehaviour 
	{
		public Animator Vespiquen_Animator;
		public RuntimeAnimatorController someController;

		private TSareenaParentMom_ConverterAnimatorController LFSTsareena_AnimatorCCA;
		private TSareenaParentMom_AnimatorBaseMovementController LFSTsareena_AnimatorCMA;
		private TSareenaParentMom_IdleAnimatorController LFSTsareena_AnimatorICA;


		public void LoadFailSafeVespiquen_AnimatorController()
		{
			LoadFailSafeVespiquen_ConvertToAnimatorController();
			LoadFailSafeVespiquen_MovementAnimatorController();
			LoadFailSafeVespiquen_IdleAnimatorController();
		}
		private void LoadFailSafeVespiquen_ConvertToAnimatorController()
		{
			LFSTsareena_AnimatorCCA.VEParentMom_ConverterToAnimatorController();
		}
		private void LoadFailSafeVespiquen_MovementAnimatorController()
		{
			LFSTsareena_AnimatorCMA.VEParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeVespiquen_IdleAnimatorController()
		{
			LFSTsareena_AnimatorICA.VEParentMom_IdleAnimatorController();
		}
	}
}
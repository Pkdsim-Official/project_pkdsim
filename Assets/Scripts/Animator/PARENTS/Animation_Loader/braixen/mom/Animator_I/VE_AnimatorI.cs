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

		private BraixenParentMom_ConverterAnimatorController LFSBraixen_AnimatorCCA;
		private BraixenParentMom_AnimatorBaseMovementController LFSBraixen_AnimatorCMA;
		private BraixenParentMom_IdleAnimatorController LFSBraixen_AnimatorICA;


		public void LoadFailSafeVespiquen_AnimatorController()
		{
			LoadFailSafeVespiquen_ConvertToAnimatorController();
			LoadFailSafeVespiquen_MovementAnimatorController();
			LoadFailSafeVespiquen_IdleAnimatorController();
		}
		private void LoadFailSafeVespiquen_ConvertToAnimatorController()
		{
			LFSBraixen_AnimatorCCA.VEParentMom_ConverterToAnimatorController();
		}
		private void LoadFailSafeVespiquen_MovementAnimatorController()
		{
			LFSBraixen_AnimatorCMA.VEParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeVespiquen_IdleAnimatorController()
		{
			LFSBraixen_AnimatorICA.VEParentMom_IdleAnimatorController();
		}
	}
}
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

		private DelphoxParentMom_ConverterAnimatorController LFSDelphox_AnimatorCCA;
		private DelphoxParentMom_AnimatorBaseMovementController LFSDelphox_AnimatorCMA;
		private DelphoxParentMom_IdleAnimatorController LFSDelphox_AnimatorICA;


		public void LoadFailSafeVespiquen_AnimatorController()
		{
			LoadFailSafeVespiquen_ConvertToAnimatorController();
			LoadFailSafeVespiquen_MovementAnimatorController();
			LoadFailSafeVespiquen_IdleAnimatorController();
		}
		private void LoadFailSafeVespiquen_ConvertToAnimatorController()
		{
			LFSDelphox_AnimatorCCA.VEParentMom_ConverterToAnimatorController();
		}
		private void LoadFailSafeVespiquen_MovementAnimatorController()
		{
			LFSDelphox_AnimatorCMA.VEParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeVespiquen_IdleAnimatorController()
		{
			LFSDelphox_AnimatorICA.VEParentMom_IdleAnimatorController();
		}
	}
}
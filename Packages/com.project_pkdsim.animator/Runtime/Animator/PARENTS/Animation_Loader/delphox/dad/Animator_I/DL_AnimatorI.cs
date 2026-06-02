using project_pkdsim.ANIMATOR.Parents.Delphox.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Delphox.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Delphox.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Delphox.Animator_I
{
	public class DelphoxFailSafe : MonoBehaviour 
	{
		public Animator DelphoxParentDad_Animator;
		public RuntimeAnimatorController someController;

		private DelphoxParentDad_ConverterAnimatorController DelphoxParentDad_AnimatorCCA;
		private DelphoxParentDad_MovementAnimatorController DelphoxParentDad_AnimatorCMA;
		private DelphoxParentDad_IdleAnimatorController DelphoxParentDad_AnimatorICA;


		public void LoadFailSafeDelphoxParentDad_AnimatorController()
		{
			LoadFailSafeDelphoxParentDad_ConvertToAnimatorController();
			LoadFailSafeDelphoxParentDad_MovementAnimatorController();
			LoadFailSafeDelphoxParentDad_IdleAnimatorController();
		}
		private void LoadFailSafeDelphoxParentDad_ConvertToAnimatorController()
		{
			DelphoxParentDad_AnimatorCCA.DL_ConverterAnimatorController();
		}
		private void LoadFailSafeDelphoxParentDad_MovementAnimatorController()
		{
			DelphoxParentDad_AnimatorCMA.DLMovementAnimatorController();
		}
		private void LoadFailSafeDelphoxParentDad_IdleAnimatorController()
		{
			DelphoxParentDad_AnimatorICA.DL_IdleAnimatorController();
		}
	}
}
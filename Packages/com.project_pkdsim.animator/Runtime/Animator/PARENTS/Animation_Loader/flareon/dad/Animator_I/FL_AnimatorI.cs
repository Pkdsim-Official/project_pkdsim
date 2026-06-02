using project_pkdsim.ANIMATOR.Parents.Flareon.Dad.converteranimations;
using project_pkdsim.ANIMATOR.Parents.Flareon.Dad.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Flareon.Dad.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Flareon.Dad.Animator_I
{
	public class FLParentDad_AnimatorI : MonoBehaviour
	{
		public Animator FlareonParentDad_Animator;
		public RuntimeAnimatorController someController;

		private FlareonParentDad_ConverterAnimatorController FlareonParentDad_AnimatorCCA;
		private FlareonParentDad_MovementAnimatorController FlareonParentDad_AnimatorCMA;
		private FlareonParentDad_IdleAnimatorController FlareonParentDad_AnimatorICA;

		public void LoadFailSafeFlareonParentDad_AnimatorController()
		{
			LoadFailSafeFlareonParentDad_ConvertToAnimatorController();
			LoadFailSafeFlareonParentDad_MovementAnimatorController();
			LoadFailSafeFlareonParentDad_IdleAnimatorController();
		}
		private void LoadFailSafeFlareonParentDad_ConvertToAnimatorController()
		{
			FlareonParentDad_AnimatorCCA.FLParentDad_ConverterAnimatorController();
		}
		private void LoadFailSafeFlareonParentDad_MovementAnimatorController()
		{
			FlareonParentDad_AnimatorCMA.FLParentDad_MovementAnimatorController();
		}
		private void LoadFailSafeFlareonParentDad_IdleAnimatorController()
		{
			FlareonParentDad_AnimatorICA.FLParentDad_IdleAnimatorController();
		}
	}
}
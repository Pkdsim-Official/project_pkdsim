using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.converteranimations;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.Animator_I
{
	public class FL_AnimatorI : MonoBehaviour 
	{
		public Animator FlareonParentDad_Animator;
		public RuntimeAnimatorController someController;

		private FlareonParentDad_ConverterToAnimatorController FlareonParentDad_AnimatorCCA;
		private FlareonParentDad_AnimatorMovementController FlareonParentDad_AnimatorCMA;
		private FlareonParentDad_IdleAnimatorController FlareonParentDad_AnimatorICA;


		public void LoadFailSafeFlareonParentDad_AnimatorController()
		{
			LoadFailSafeFlareonParentDad_ConvertToAnimatorController();
			LoadFailSafeFlareonParentDad_MovementAnimatorController();
			LoadFailSafeFlareonParentDad_IdleAnimatorController();
		}
		private void LoadFailSafeFlareonParentDad_ConvertToAnimatorController()
		{
			FlareonParentDad_AnimatorCCA.C_ConverterToAnimatorController();
		}
		private void LoadFailSafeFlareonParentDad_MovementAnimatorController()
		{
			FlareonParentDad_AnimatorCMA.CMovementAnimatorController();
		}
		private void LoadFailSafeFlareonParentDad_IdleAnimatorController()
		{
			FlareonParentDad_AnimatorICA.C_IdleAnimatorController();
		}
	}
}
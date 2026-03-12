using Project_Pkdsim.ANIMATOR.Parents.Flareon.Mom.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Parents.Flareon.Mom.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Parents.Flareon.Mom.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Flareon.Mom.Animator_I
{
	public class LFS_FlareonFailSafe : MonoBehaviour 
	{
		public Animator FlareonParentMom_Animator;
		public RuntimeAnimatorController someController;

		private FlareonParentMom_ConverterAnimatorController LFSFlareon_AnimatorCCA;
		private FlareonParentMom_MovementAnimatorController LFSFlareon_AnimatorCMA;
		private FlareonParentMom_IdleAnimatorController LFSFlareon_AnimatorICA;


		public void LoadFailSafeFlareon_AnimatorController()
		{
			LoadFailSafeFlareon_ConvertToAnimatorController();
			LoadFailSafeFlareon_MovementAnimatorController();
			LoadFailSafeFlareon_IdleAnimatorController();
		}
		private void LoadFailSafeFlareon_ConvertToAnimatorController()
		{
			LFSFlareon_AnimatorCCA.FLParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeFlareon_MovementAnimatorController()
		{
			LFSFlareon_AnimatorCMA.FLParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeFlareon_IdleAnimatorController()
		{
			LFSFlareon_AnimatorICA.FLParentMom_IdleAnimatorController();
		}
	}
}
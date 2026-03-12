using Project_Pkdsim.ANIMATOR.Parents.Frostlass.Mom.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Parents.Frostlass.Mom.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Frostlass.Mom.Animator_I
{
	public class LFS_VespiquenFailSafe : MonoBehaviour 
	{
		public Animator FrostlassParentMom_Animator;
		public RuntimeAnimatorController someController;

		private FrostlassParentMom_ConverterAnimatorController LFSFrostlass_AnimatorCCA;
		private FrostlassParentMom_MovementAnimatorController LFSFrostlass_AnimatorCMA;
		private FrostlassParentMom_IdleAnimatorController LFSFrostlass_AnimatorICA;


		public void LoadFailSafeFrostlass_AnimatorController()
		{
			LoadFailSafeVespiquen_ConvertToAnimatorController();
			LoadFailSafeVespiquen_MovementAnimatorController();
			LoadFailSafeVespiquen_IdleAnimatorController();
		}
		private void LoadFailSafeVespiquen_ConvertToAnimatorController()
		{
			LFSFrostlass_AnimatorCCA.FRParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeVespiquen_MovementAnimatorController()
		{
			LFSFrostlass_AnimatorCMA.FRParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeVespiquen_IdleAnimatorController()
		{
			LFSFrostlass_AnimatorICA.FRParentMom_IdleAnimatorController();
		}
	}
}
using Project_Pkdsim.ANIMATOR.Parents.Jolteon.Mom.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Parents.Jolteon.Mom.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Parents.Jolteon.Mom.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Jolteon.Mom.Animator_I
{
	public class LFS_VespiquenFailSafe : MonoBehaviour 
	{
		public Animator JolteonParentMom_Animator;
		public RuntimeAnimatorController someController;

		private JolteonParentMom_ConverterAnimatorController LFSJolteon_AnimatorCCA;
		private JolteonParentMom_MovementAnimatorController LFSJolteon_AnimatorCMA;
		private JolteonParentMom_IdleAnimatorController LFSJolteon_AnimatorICA;


		public void LoadFailSafeJolteon_AnimatorController()
		{
			LoadFailSafeVespiquen_ConvertToAnimatorController();
			LoadFailSafeVespiquen_MovementAnimatorController();
			LoadFailSafeVespiquen_IdleAnimatorController();
		}
		private void LoadFailSafeVespiquen_ConvertToAnimatorController()
		{
			LFSJolteon_AnimatorCCA.JTParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeVespiquen_MovementAnimatorController()
		{
			LFSJolteon_AnimatorCMA.JTParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeVespiquen_IdleAnimatorController()
		{
			LFSJolteon_AnimatorICA.JTParentMom_IdleAnimatorController();
		}
	}
}
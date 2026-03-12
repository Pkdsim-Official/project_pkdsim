using Project_Pkdsim.ANIMATOR.Parents.Vaporeon.Mom.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Parents.Vaporeon.Mom.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Parents.Vaporeon.Mom.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Vaporeon.Mom.Animator_I
{
	public class LFS_VespiquenFailSafe : MonoBehaviour
	{
		public Animator VaporeonParentMom_Animator;
		public RuntimeAnimatorController someController;

		private VaporeonParentMom_ConverterAnimatorController LFSVaporeon_AnimatorCCA;
		private VaporeonParentMom_MovementAnimatorController LFSVaporeon_AnimatorCMA;
		private VaporeonParentMom_IdleAnimatorController LFSVaporeon_AnimatorICA;


		public void LoadFailSafeVaporeon_AnimatorController()
		{
			LoadFailSafeVespiquen_ConvertToAnimatorController();
			LoadFailSafeVespiquen_MovementAnimatorController();
			LoadFailSafeVespiquen_IdleAnimatorController();
		}
		private void LoadFailSafeVespiquen_ConvertToAnimatorController()
		{
			LFSVaporeon_AnimatorCCA.VPParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeVespiquen_MovementAnimatorController()
		{
			LFSVaporeon_AnimatorCMA.VPParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeVespiquen_IdleAnimatorController()
		{
			LFSVaporeon_AnimatorICA.VPParentMom_IdleAnimatorController();
		}
	}
}
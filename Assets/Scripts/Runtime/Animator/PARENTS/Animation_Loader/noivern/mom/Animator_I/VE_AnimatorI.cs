using Project_Pkdsim.ANIMATOR.Parents.Noivern.Mom.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Parents.Noivern.Mom.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Parents.Noivern.Mom.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Noivern.Mom.Animator_I
{
	public class LFS_NoivernFailSafe : MonoBehaviour
	{
		public Animator NoivernParentMom_Animator;
		public RuntimeAnimatorController someController;

		private NoivernParentMom_ConverterAnimatorController LFSNoivern_AnimatorCCA;
		private NoivernParentMom_MovementAnimatorController LFSNoivern_AnimatorCMA;
		private NoivernParentMom_IdleAnimatorController LFSNoivern_AnimatorICA;

		public void LoadFailSafeNoivern_AnimatorController()
		{
			LoadFailSafeNoivern_ConvertToAnimatorController();
			LoadFailSafeNoivern_MovementAnimatorController();
			LoadFailSafeNoivern_IdleAnimatorController();
		}
		private void LoadFailSafeNoivern_ConvertToAnimatorController()
		{
			LFSNoivern_AnimatorCCA.NOIParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeNoivern_MovementAnimatorController()
		{
			LFSNoivern_AnimatorCMA.NOIParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeNoivern_IdleAnimatorController()
		{
			LFSNoivern_AnimatorICA.NOIParentMom_IdleAnimatorController();
		}
	}
}
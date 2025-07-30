using project_pkdsim.ANIMATOR.Parents.Noivern.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Noivern.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Noivern.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.Animator_I
{
	public class LFS_NoivernFailSafe : MonoBehaviour 
	{
		public Animator Noivern_Animator;
		public RuntimeAnimatorController someController;
		private NoivernConverterAnimatorController LFSNoivern_AnimatorCCA;
		private NoivernParent_AnimatorBaseMovementController LFSNoivern_AnimatorCMA;
		private Noivern_IdleAnimatorController LFSNoivern_AnimatorICA;


		public void LoadFailSafeNoivern_AnimatorController()
		{
			LoadFailSafeNoivern_ConvertToAnimatorController();
			LoadFailSafeNoivern_MovementAnimatorController();
			LoadFailSafeNoivern_IdleAnimatorController();
		}
		private void LoadFailSafeNoivern_ConvertToAnimatorController()
		{
			LFSNoivern_AnimatorCCA.NOIConverterToAnimatorController();
		}
		private void LoadFailSafeNoivern_MovementAnimatorController()
		{
			LFSNoivern_AnimatorCMA.NOIMovementAnimatorController();
		}
		private void LoadFailSafeNoivern_IdleAnimatorController()
		{
			LFSNoivern_AnimatorICA.NOI_IdleAnimatorController();
		}
	}
}
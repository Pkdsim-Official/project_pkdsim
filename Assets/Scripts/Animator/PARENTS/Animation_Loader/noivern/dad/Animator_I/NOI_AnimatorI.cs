using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.Dad.Animator_I
{
	public class LFS_NoivernFailSafe : MonoBehaviour
	{
		public Animator NoivernParentDad_Animator;
		public RuntimeAnimatorController someController;
		private NoivernConverterAnimatorController LFSNoivern_AnimatorCCA;
		private NoivernParentDad_MovementAnimatorController LFSNoivern_AnimatorCMA;
		private Noivern_IdleAnimatorController LFSNoivern_AnimatorICA;


		public void LoadFailSafeNoivern_AnimatorController()
		{
			LoadFailSafeNoivern_ConvertToAnimatorController();
			LoadFailSafeNoivern_MovementAnimatorController();
			LoadFailSafeNoivern_IdleAnimatorController();
		}
		private void LoadFailSafeNoivern_ConvertToAnimatorController()
		{
			LFSNoivern_AnimatorCCA.NOIParentDad_ConverterAnimatorController();
		}
		private void LoadFailSafeNoivern_MovementAnimatorController()
		{
			LFSNoivern_AnimatorCMA.NOIParentDad_MovementAnimatorController();
		}
		private void LoadFailSafeNoivern_IdleAnimatorController()
		{
			LFSNoivern_AnimatorICA.NOIParentDad_IdleAnimatorController();
		}
	}
}
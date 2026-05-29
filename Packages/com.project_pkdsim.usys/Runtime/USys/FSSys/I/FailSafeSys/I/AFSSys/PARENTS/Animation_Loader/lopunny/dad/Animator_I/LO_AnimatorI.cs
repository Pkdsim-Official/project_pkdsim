using project_pkdsim.ANIMATOR.Parents.Lopunny.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Lopunny.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Lopunny.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lopunny.Animator_I
{
	public class LFS_LopunnyFailSafe : MonoBehaviour 
	{
		public Animator Lopunny_Animator;
		public RuntimeAnimatorController someController;

		private Lopunny_ConverterToAnimatorController LFSLopunny_AnimatorCCA;
		private LopunnyParent_AnimatorMovementController LFSLopunny_AnimatorCMA;
		private Lopunny_IdleAnimatorController LFSLopunny_AnimatorICA;


		public void LoadFailSafeLopunny_AnimatorController()
		{
			LoadFailSafeLopunny_ConvertToAnimatorController();
			LoadFailSafeLopunny_MovementAnimatorController();
			LoadFailSafeLopunny_IdleAnimatorController();
		}
		private void LoadFailSafeLopunny_ConvertToAnimatorController()
		{
			LFSLopunny_AnimatorCCA.LO_ConverterToAnimatorController();
		}
		private void LoadFailSafeLopunny_MovementAnimatorController()
		{
			LFSLopunny_AnimatorCMA.LOMovementAnimatorController();
		}
		private void LoadFailSafeLopunny_IdleAnimatorController()
		{
			LFSLopunny_AnimatorICA.LO_IdleAnimatorController();
		}
	}
}
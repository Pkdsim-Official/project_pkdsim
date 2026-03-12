using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.idlebaseanimation;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.movementbasedanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.Animator_I
{
	public class LFS_LopunnyFailSafe : MonoBehaviour 
	{
		public Animator LopunnyParentMom_Animator;
		public RuntimeAnimatorController someController;

		private LopunnyParentMom_ConverterAnimatorController LFSLopunny_AnimatorCCA;
		private LopunnyParentMom_MovementAnimatorController LFSLopunny_AnimatorCMA;
		private LopunnyParentMom_IdleAnimatorController LFSLopunny_AnimatorICA;

		public void LoadFailSafeLopunny_AnimatorController()
		{
			LoadFailSafeLopunny_ConvertToAnimatorController();
			LoadFailSafeLopunny_MovementAnimatorController();
			LoadFailSafeLopunny_IdleAnimatorController();
		}
		private void LoadFailSafeLopunny_ConvertToAnimatorController()
		{
			LFSLopunny_AnimatorCCA.LOParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeLopunny_MovementAnimatorController()
		{
			LFSLopunny_AnimatorCMA.LOParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeLopunny_IdleAnimatorController()
		{
			LFSLopunny_AnimatorICA.LOParentMom_IdleAnimatorController();
		}
	}
}
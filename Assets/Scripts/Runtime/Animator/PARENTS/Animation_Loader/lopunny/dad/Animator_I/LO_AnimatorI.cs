using Project_Pkdsim.ANIMATOR.Parents.Lopunny.Dad.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Parents.Lopunny.Dad.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Parents.Lopunny.Dad.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Lopunny.Dad.Animator_I
{
	public class LFS_LopunnyFailSafe : MonoBehaviour
	{
		public Animator LopunnyParentDad_Animator;
		public RuntimeAnimatorController someController;

		private LopunnyParentDad_ConverterAnimatorController LFSLopunny_AnimatorCCA;
		private LopunnyParentDad_MovementAnimatorController LFSLopunny_AnimatorCMA;
		private LopunnyParentDad_IdleAnimatorController LFSLopunny_AnimatorICA;


		public void LoadFailSafeLopunny_AnimatorController()
		{
			LoadFailSafeLopunny_ConvertToAnimatorController();
			LoadFailSafeLopunny_MovementAnimatorController();
			LoadFailSafeLopunny_IdleAnimatorController();
		}
		private void LoadFailSafeLopunny_ConvertToAnimatorController()
		{
			LFSLopunny_AnimatorCCA.LOParentDad_ConverterAnimatorController();
		}
		private void LoadFailSafeLopunny_MovementAnimatorController()
		{
			LFSLopunny_AnimatorCMA.LOParentDad_MovementAnimatorController();
		}
		private void LoadFailSafeLopunny_IdleAnimatorController()
		{
			LFSLopunny_AnimatorICA.LOParentDad_IdleAnimatorController();
		}
	}
}
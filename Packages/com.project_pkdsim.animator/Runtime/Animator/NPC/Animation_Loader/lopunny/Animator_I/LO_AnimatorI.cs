using project_pkdsim.ANIMATOR.NPC.Lopunny.idlebaseanimation;
using project_pkdsim.ANIMATOR.NPC.Lopunny.movementbasedanimations;
using project_pkdsim.ANIMATOR.NPC.Lopunny.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Lopunny.Animator_I
{
	public class LFS_LopunnyFailSafe : MonoBehaviour 
	{
		public Animator Lopunny_Animator;
		public RuntimeAnimatorController someController;

		private Lopunny_ConverterAnimatorController LFSLopunny_AnimatorCCA;
		private Lopunny_MovementAnimatorController LFSLopunny_AnimatorCMA;
		private Lopunny_IdleAnimatorController LFSLopunny_AnimatorICA;


		public void LoadFailSafeLopunny_AnimatorController()
		{
			LoadFailSafeLopunny_ConvertToAnimatorController();
			LoadFailSafeLopunny_MovementAnimatorController();
			LoadFailSafeLopunny_IdleAnimatorController();
		}
		private void LoadFailSafeLopunny_ConvertToAnimatorController()
		{
			LFSLopunny_AnimatorCCA.LO_ConverterAnimatorController();
		}
		private void LoadFailSafeLopunny_MovementAnimatorController()
		{
			LFSLopunny_AnimatorCMA.LO_MovementAnimatorController();
		}
		private void LoadFailSafeLopunny_IdleAnimatorController()
		{
			LFSLopunny_AnimatorICA.LO_IdleAnimatorController();
		}
	}
}
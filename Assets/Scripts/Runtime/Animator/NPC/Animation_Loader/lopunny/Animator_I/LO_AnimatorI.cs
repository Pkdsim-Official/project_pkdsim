using Project_Pkdsim.ANIMATOR.Npcs.Lopunny.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Npcs.Lopunny.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Npcs.Lopunny.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Lopunny.Animator_I
{
	public class LFS_LopunnyFailSafe : MonoBehaviour 
	{
		public Animator Lopunny_Animator;
		public RuntimeAnimatorController someController;

		private Lopunny_CoverterAnimatorController LFSLopunny_AnimatorCCA;
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
			LFSLopunny_AnimatorCCA.LO_CoverterToAnimatorController();
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
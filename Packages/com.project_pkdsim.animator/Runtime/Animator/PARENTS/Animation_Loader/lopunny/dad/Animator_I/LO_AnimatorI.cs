using project_pkdsim.ANIMATOR.Parents.Lopunny.Dad.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Lopunny.Dad.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Lopunny.Dad.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lopunny.Dad.Animator_I
{
	public class LopunnyFailSafe : MonoBehaviour 
	{
		public Animator Lopunny_Animator;
		public RuntimeAnimatorController someController;

		private Lopunny_ConverterToAnimatorController Lopunny_AnimatorCCA;
		private LopunnyParent_AnimatorMovementController Lopunny_AnimatorCMA;
		private Lopunny_IdleAnimatorController Lopunny_AnimatorICA;


		public void LoadFailSafeLopunny_AnimatorController()
		{
			LoadFailSafeLopunny_ConvertToAnimatorController();
			LoadFailSafeLopunny_MovementAnimatorController();
			LoadFailSafeLopunny_IdleAnimatorController();
		}
		private void LoadFailSafeLopunny_ConvertToAnimatorController()
		{
			Lopunny_AnimatorCCA.LO_ConverterToAnimatorController();
		}
		private void LoadFailSafeLopunny_MovementAnimatorController()
		{
			Lopunny_AnimatorCMA.LOMovementAnimatorController();
		}
		private void LoadFailSafeLopunny_IdleAnimatorController()
		{
			Lopunny_AnimatorICA.LO_IdleAnimatorController();
		}
	}
}
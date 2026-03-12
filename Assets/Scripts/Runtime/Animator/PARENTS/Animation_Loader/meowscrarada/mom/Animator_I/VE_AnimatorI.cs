using Project_Pkdsim.ANIMATOR.Parents.Meowscarada.Mom.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Parents.Meowscarada.Mom.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Parents.Meowscarada.Mom.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Meowscarada.Mom.Animator_I
{
	public class LFS_VespiquenFailSafe : MonoBehaviour 
	{
		public Animator MeowscaradaParentMom_Animator;
		public RuntimeAnimatorController someController;

		private MeowscaradaParentMom_ConverterAnimatorController LFSMeowscarada_AnimatorCCA;
		private MeowscaradaParentMom_MovementAnimatorController LFSMeowscarada_AnimatorCMA;
		private MeowscaradaParentMom_IdleAnimatorController LFSMeowscarada_AnimatorICA;


		public void LoadFailSafeMeowscarada_AnimatorController()
		{
			LoadFailSafeVespiquen_ConvertToAnimatorController();
			LoadFailSafeVespiquen_MovementAnimatorController();
			LoadFailSafeVespiquen_IdleAnimatorController();
		}
		private void LoadFailSafeVespiquen_ConvertToAnimatorController()
		{
			LFSMeowscarada_AnimatorCCA.MEOWParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeVespiquen_MovementAnimatorController()
		{
			LFSMeowscarada_AnimatorCMA.MEOWParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeVespiquen_IdleAnimatorController()
		{
			LFSMeowscarada_AnimatorICA.MEOWParentMom_IdleAnimatorController();
		}
	}
}
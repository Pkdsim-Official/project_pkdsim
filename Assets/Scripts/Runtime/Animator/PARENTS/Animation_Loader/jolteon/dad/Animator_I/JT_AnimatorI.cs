using Project_Pkdsim.ANIMATOR.Parents.Jolteon.Dad.converteranimations;
using Project_Pkdsim.ANIMATOR.Parents.Jolteon.Dad.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Parents.Jolteon.Dad.movementbasedanimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Jolteon.Dad.Animator_I
{
	public class JT_AnimatorI : MonoBehaviour 
	{
		public Animator JolteonParentDad_Animator;
		public RuntimeAnimatorController someController;

		private JolteonParentDad_ConverterAnimatorController LFSJolteon_AnimatorCCA;
		private JolteonParentDad_MovementAnimatorController LFSJolteon_AnimatorCMA;
		private JolteonParentDad_AnimatorIdleController LFSJolteon_AnimatorICA;

		public void LoadFailSafeJolteon_AnimatorController()
		{
			LoadFailSafeJolteon_ConvertToAnimatorController();
			LoadFailSafeJolteon_MovementAnimatorController();
			LoadFailSafeJolteon_IdleAnimatorController();
		}

		private void LoadFailSafeJolteon_ConvertToAnimatorController()
		{
			LFSJolteon_AnimatorCCA.JTParentDad_ConverterAnimatorController();
		}
		private void LoadFailSafeJolteon_MovementAnimatorController()
		{
			LFSJolteon_AnimatorCMA.JTParentDad_MovementAnimatorController();
		}
		private void LoadFailSafeJolteon_IdleAnimatorController()
		{
			LFSJolteon_AnimatorICA.JTParentDad_IdleAnimatorController();
		}
	}
}
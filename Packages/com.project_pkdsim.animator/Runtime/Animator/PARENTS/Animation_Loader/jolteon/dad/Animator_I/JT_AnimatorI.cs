using project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.converteranimations;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.Animator_I
{
	public class JT_AnimatorI : MonoBehaviour 
	{
		public Animator JolteonParent_Animator;
		public RuntimeAnimatorController someController;

		private JolteonParent_ConverterAnimatorController JolteonParent_AnimatorCCA;
		private JolteonParent_AnimatorMovementController JolteonParent_AnimatorCMA;
		private JolteonParent_AnimatorIdleController JolteonParent_AnimatorICA;

		private void JolteonParent_AnimatorController()
		{
			JolteonParent_Animator = gameObject.GetComponent<Animator>();
			JolteonParent_Animator.runtimeAnimatorController = someController;
		}
		private void ConvertToAnimatorController()
		{

		}
		private void MovementAnimatorController()
		{
			
		}
		private void _IdleAnimatorController()
		{
			
		}
	}
}
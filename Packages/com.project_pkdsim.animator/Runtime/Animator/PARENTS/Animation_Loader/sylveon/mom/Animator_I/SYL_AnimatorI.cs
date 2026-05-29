using project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.converteranimations;
using project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.Animator_I
{
	public class SYL_AnimatorI : MonoBehaviour 
	{
		public Animator Sylveon_Animator;
		public RuntimeAnimatorController someController;

		private Sylveon_ConverterToAnimatorController Sylveon_AnimatorCCA;
		private SylveonParent_AnimatorMovementController Sylveon_AnimatorCMA;
		private Sylveon_IdleAnimatorController Sylveon_AnimatorICA;


		private void Sylveon_AnimatorController()
		{
			Sylveon_Animator = gameObject.GetComponent<Animator>();
			Sylveon_Animator.runtimeAnimatorController = someController;
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
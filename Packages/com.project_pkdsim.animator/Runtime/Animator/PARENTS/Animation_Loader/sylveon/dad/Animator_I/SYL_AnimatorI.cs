using project_pkdsim.ANIMATOR.Parents.Sylveon.converteranimations;
using project_pkdsim.ANIMATOR.Parents.Sylveon.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Sylveon.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Sylveon.Animator_I
{
	public class SYL_AnimatorI : MonoBehaviour 
	{
		public Animator Sylveon_Animator;
		public RuntimeAnimatorController someController;

		private Sylveon_ConverterAnimatorController Sylveon_AnimatorCCA;
		private SylveonParent_MovementAnimatorController Sylveon_AnimatorCMA;
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
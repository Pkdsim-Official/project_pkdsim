using project_pkdsim.ANIMATOR.NPC.Sylveon.converteranimations;
using project_pkdsim.ANIMATOR.NPC.Sylveon.idlebaseanimation;
using project_pkdsim.ANIMATOR.NPC.Sylveon.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Sylveon.Animator_I
{
	public class SYL_AnimatorI : MonoBehaviour 
	{
		public Animator Sylveon_Animator;
		public RuntimeAnimatorController someController;

		private Sylveon_ConverterToAnimatorController LFSSylveon_AnimatorCCA;
		private Sylveon_AnimatorMovementController LFSSylveon_AnimatorCMA;
		private Sylveon_IdleAnimatorController LFSSylveon_AnimatorICA;


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
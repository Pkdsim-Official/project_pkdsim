using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.idlebaseanimation;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.converteranimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.movementbasedanimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.Animator_I
{
	public class VaporeonParentDad_AnimatorI : MonoBehaviour
	{
		public Animator VaporeonParentDad_Animator;
		public RuntimeAnimatorController someController;

		private VaporeonParentDad_ConverterAnimatorController VaporeonParentDad_AnimatorCCA;
		private VaporeonParentDad_MovementAnimatorController VaporeonParentDad_AnimatorCMA;
		private VaporeonParentDad_IdleAnimatorController VaporeonParentDad_AnimatorICA;

		private void Vaporeon_AnimatorController()
		{
			VaporeonParentDad_Animator = gameObject.GetComponent<Animator>();
			VaporeonParentDad_Animator.runtimeAnimatorController = someController;
		}
		private void ConvertToAnimatorController()
		{
			VaporeonParentDad_AnimatorCCA.VPParentDad_ConverterAnimatorController();
		}
		private void MovementAnimatorController()
		{
			VaporeonParentDad_AnimatorCMA.VPParentDad_MovementAnimatorController();
		}
		private void IdleAnimatorController()
		{
			VaporeonParentDad_AnimatorICA.VPParentDad_IdleAnimatorController();
		}
	}
}
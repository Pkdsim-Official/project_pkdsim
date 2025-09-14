using project_pkdsim.ANIMATOR.Parents.Espeon.Mom.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Espeon.Mom.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Espeon.Mom.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Espeon.Mom.Animator_I
{
	public class LFS_EspeonFailSafe : MonoBehaviour
	{
		public Animator EspeonParentMom_Animator;
		public RuntimeAnimatorController someController;

		private EspeonParentMom_ConverterAnimatorController LFSEspeon_AnimatorCCA;
		private EspeonParentMom_MovementAnimatorController LFSEspeon_AnimatorCMA;
		private EspeonParentMom_IdleAnimatorController LFSEspeon_AnimatorICA;

		public void LoadFailSafeEspeon_AnimatorController()
		{
			LoadFailSafeEspeon_ConvertToAnimatorController();
			LoadFailSafeEspeon_MovementAnimatorController();
			LoadFailSafeEspeon_IdleAnimatorController();
		}
		private void LoadFailSafeEspeon_ConvertToAnimatorController()
		{
			LFSEspeon_AnimatorCCA.ESParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeEspeon_MovementAnimatorController()
		{
			LFSEspeon_AnimatorCMA.ESParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeEspeon_IdleAnimatorController()
		{
			LFSEspeon_AnimatorICA.ESParentMom_IdleAnimatorController();
		}
	}
}
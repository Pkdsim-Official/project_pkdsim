using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.idlebaseanimation;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.movementbasedanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.Animator_I
{
	public class LFS_VespiquenFailSafe : MonoBehaviour
	{
		public Animator SalazzleParentMom_Animator;
		public RuntimeAnimatorController someController;

		private SalazzleParentMom_ConverterAnimatorController LFSSalazzle_AnimatorCCA;
		private SalazzleParentMom_MovementAnimatorController LFSSalazzle_AnimatorCMA;
		private SalazzleParentMom_IdleAnimatorController LFSSalazzle_AnimatorICA;


		public void LoadFailSafeSalazzle_AnimatorController()
		{
			LoadFailSafeVespiquen_ConvertToAnimatorController();
			LoadFailSafeVespiquen_MovementAnimatorController();
			LoadFailSafeVespiquen_IdleAnimatorController();
		}
		private void LoadFailSafeVespiquen_ConvertToAnimatorController()
		{
			LFSSalazzle_AnimatorCCA.SParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeVespiquen_MovementAnimatorController()
		{
			LFSSalazzle_AnimatorCMA.SParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeVespiquen_IdleAnimatorController()
		{
			LFSSalazzle_AnimatorICA.SParentMom_IdleAnimatorController();
		}
	}
}
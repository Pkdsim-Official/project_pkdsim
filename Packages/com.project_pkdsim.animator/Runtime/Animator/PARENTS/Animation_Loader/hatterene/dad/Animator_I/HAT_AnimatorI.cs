using project_pkdsim.ANIMATOR.Parents.Hatterene.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Hatterene.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Hatterene.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Hatterene.Animator_I
{
	public class HattereneFailSafe : MonoBehaviour 
	{
		public Animator Hatterene_Animator;
		public RuntimeAnimatorController someController;

		private Hatterene_ConverterAnimatorController Hatterene_AnimatorCCA;
		private HattereneParent_MovementAnimatorController Hatterene_AnimatorCMA;
		private Hatterene_IdleAnimatorController Hatterene_AnimatorICA;


		public void LoadFailSafeHatterene_AnimatorController()
		{
			LoadFailSafeHatterene_ConvertToAnimatorController();
			LoadFailSafeHatterene_MovementAnimatorController();
			LoadFailSafeHatterene_IdleAnimatorController();
		}
		private void LoadFailSafeHatterene_ConvertToAnimatorController()
		{
			Hatterene_AnimatorCCA.HAT_ConverterAnimatorController();
		}
		private void LoadFailSafeHatterene_MovementAnimatorController()
		{
			Hatterene_AnimatorCMA.HAT_MovementAnimatorController();
		}
		private void LoadFailSafeHatterene_IdleAnimatorController()
		{
			Hatterene_AnimatorICA.HAT_IdleAnimatorController();
		}
	}
}
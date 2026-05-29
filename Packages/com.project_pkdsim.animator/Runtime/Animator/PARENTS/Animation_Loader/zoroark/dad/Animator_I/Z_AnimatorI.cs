using project_pkdsim.ANIMATOR.Parents.Zoroark.Dad.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Zoroark.Dad.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Zoroark.Dad.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Zoroark.Dad.Animator_I
{
	public class ZoroarkFailSafe : MonoBehaviour 
	{
		public Animator Zoroark_Animator;
		public RuntimeAnimatorController someController;

		private ZoroarkParentDad_ConverterToAnimatorController Zoroark_AnimatorCCA;
		private ZoroarkParentDad_AnimatorMovementController Zoroark_AnimatorCMA;
		private ZoroarkParentDad_IdleAnimatorController Zoroark_AnimatorICA;


		public void LoadFailSafeZoroark_AnimatorController()
		{
			LoadFailSafeZoroark_ConvertToAnimatorController();
			LoadFailSafeZoroark_MovementAnimatorController();
			LoadFailSafeZoroark_IdleAnimatorController();
		}
		private void LoadFailSafeZoroark_ConvertToAnimatorController()
		{
			Zoroark_AnimatorCCA.ZParentDad_ConverterToAnimatorController();
		}
		private void LoadFailSafeZoroark_MovementAnimatorController()
		{
			Zoroark_AnimatorCMA.ZParentDad_MovementAnimatorController();
		}
		private void LoadFailSafeZoroark_IdleAnimatorController()
		{
			Zoroark_AnimatorICA.ZParentDad_IdleAnimatorController();
		}
	}
}
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Dad.idlebaseanimation;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Dad.movementbasedanimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Dad.converteranimations;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Dad.Animator_I
{
	public class GardevoirParentDad_FailSafe : MonoBehaviour 
	{
		public Animator GardevoirParentDad_Animator;
		public RuntimeAnimatorController someController;

		private GardevoirParentDad_ConverterAnimatorController GardevoirParentDad_AnimatorCCA;
		private GardevoirParentDad_MovementAnimatorController GardevoirParentDad_AnimatorCMA;
		private GardevoirParentDad_IdleAnimatorController GardevoirParentDad_AnimatorICA;


		public void LoadFailSafeGardevoirParentDad_AnimatorController()
		{
			LoadFailSafeGardevoirParentDad_ConvertToAnimatorController();
			LoadFailSafeGardevoirParentDad_MovementAnimatorController();
			LoadFailSafeGardevoirParentDad_IdleAnimatorController();
		}
		private void LoadFailSafeGardevoirParentDad_ConvertToAnimatorController()
		{
			GardevoirParentDad_AnimatorCCA.GARD_ConverterAnimatorController();
		}
		private void LoadFailSafeGardevoirParentDad_MovementAnimatorController()
		{
			GardevoirParentDad_AnimatorCMA.GARDMovementAnimatorController();
		}
		private void LoadFailSafeGardevoirParentDad_IdleAnimatorController()
		{
			GardevoirParentDad_AnimatorICA.GARD_IdleAnimatorController();
		}
	}
}
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.idlebaseanimation;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.converteranimations;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.Animator_I
{
	public class BeedrillParentDad_FailSafe : MonoBehaviour 
	{
		public Animator BeedrillParentDad_Animator;
		public RuntimeAnimatorController someController;

		private BeedrillParentDad_ConverterAnimatorController BeedrillParentDad_AnimatorCCA;
		private BeedrillParentDad_MovementAnimatorController BeedrillParentDad_AnimatorCMA;
		private BeedrillParentDad_IdleAnimatorController BeedrillParentDad_AnimatorICA;

		public void LoadFailSafeBeedrillParentDad_AnimatorController()
		{
			LoadFailSafeBeedrillParentDad_ConvertToAnimatorController();
			LoadFailSafeBeedrillParentDad_MovementAnimatorController();
			LoadFailSafeBeedrillParentDad_IdleAnimatorController();
		}
		private void LoadFailSafeBeedrillParentDad_ConvertToAnimatorController()
		{
			BeedrillParentDad_AnimatorCCA.BE_ConverterAnimatorController();
		}
		private void LoadFailSafeBeedrillParentDad_MovementAnimatorController()
		{
			BeedrillParentDad_AnimatorCMA.BE_MovementAnimatorController();
		}
		private void LoadFailSafeBeedrillParentDad_IdleAnimatorController()
		{
			BeedrillParentDad_AnimatorICA.BE_IdleAnimatorController();
		}
	}
}
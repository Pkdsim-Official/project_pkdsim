using project_pkdsim.ANIMATOR.Parents.Tsareena.Dad.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Dad.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Dad.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Tsareena.Dad.Animator_I
{
	public class LFS_TsareenaFailSafe : MonoBehaviour 
	{
		public Animator TsareenaParentDad_Animator;
		public RuntimeAnimatorController someController;

		private TsareenaParentDad_ConverterAnimatorController LFSTsareena_AnimatorCCA;
		private TsareenaParentDad_MovementAnimatorController LFSTsareena_AnimatorCMA;
		private TsareenaParentDad_IdleAnimatorController LFSTsareena_AnimatorICA;


		public void LoadFailSafeTsareena_AnimatorController()
		{
			LoadFailSafeTsareena_ConvertToAnimatorController();
			LoadFailSafeTsareena_MovementAnimatorController();
			LoadFailSafeTsareena_IdleAnimatorController();
		}
		private void LoadFailSafeTsareena_ConvertToAnimatorController()
		{
			LFSTsareena_AnimatorCCA.TParentDad_ConverterAnimatorController();
		}
		private void LoadFailSafeTsareena_MovementAnimatorController()
		{
			LFSTsareena_AnimatorCMA.TParentDad_MovementAnimatorController();
		}
		private void LoadFailSafeTsareena_IdleAnimatorController()
		{
			LFSTsareena_AnimatorICA.TParentDad_IdleAnimatorController();
		}
	}
}
using project_pkdsim.ANIMATOR.Parents.Tsareena.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Tsareena.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Tsareena.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Tsareena.Animator_I
{
	public class LFS_TsareenaFailSafe : MonoBehaviour 
	{
		public Animator Tsareena_Animator;
		public RuntimeAnimatorController someController;

		private TsareenaCoverterAnimatorController LFSTsareena_AnimatorCCA;
		private TsareenaParent_AnimatorBaseMovementController LFSTsareena_AnimatorCMA;
		private Tsareena_IdleAnimatorController LFSTsareena_AnimatorICA;


		public void LoadFailSafeTsareena_AnimatorController()
		{
			LoadFailSafeTsareena_ConvertToAnimatorController();
			LoadFailSafeTsareena_MovementAnimatorController();
			LoadFailSafeTsareena_IdleAnimatorController();
		}
		private void LoadFailSafeTsareena_ConvertToAnimatorController()
		{
			LFSTsareena_AnimatorCCA.TCoverterToAnimatorController();
		}
		private void LoadFailSafeTsareena_MovementAnimatorController()
		{
			LFSTsareena_AnimatorCMA.TMovementAnimatorController();
		}
		private void LoadFailSafeTsareena_IdleAnimatorController()
		{
			LFSTsareena_AnimatorICA.T_IdleAnimatorController();
		}
	}
}
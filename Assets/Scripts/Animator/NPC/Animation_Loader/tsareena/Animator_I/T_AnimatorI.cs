using project_pkdsim.ANIMATOR.Npcs.Tsareena.idlebaseanimation;
using project_pkdsim.ANIMATOR.Npcs.Tsareena.movementbasedanimations;
using project_pkdsim.ANIMATOR.Npcs.Tsareena.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Tsareena.Animator_I
{
	public class LFS_TsareenaFailSafe : MonoBehaviour 
	{
		public Animator Tsareena_Animator;
		public RuntimeAnimatorController someController;

		private Tsareena_CoverterAnimatorController LFSTsareena_AnimatorCCA;
		private Tsareena_MovementAnimatorController LFSTsareena_AnimatorCMA;
		private Tsareena_IdleAnimatorController LFSTsareena_AnimatorICA;


		public void LoadFailSafeTsareena_AnimatorController()
		{
			LoadFailSafeTsareena_ConvertToAnimatorController();
			LoadFailSafeTsareena_MovementAnimatorController();
			LoadFailSafeTsareena_IdleAnimatorController();
		}
		private void LoadFailSafeTsareena_ConvertToAnimatorController()
		{
			LFSTsareena_AnimatorCCA.T_CoverterToAnimatorController();
		}
		private void LoadFailSafeTsareena_MovementAnimatorController()
		{
			LFSTsareena_AnimatorCMA.T_MovementAnimatorController();
		}
		private void LoadFailSafeTsareena_IdleAnimatorController()
		{
			LFSTsareena_AnimatorICA.T_IdleAnimatorController();
		}
	}
}
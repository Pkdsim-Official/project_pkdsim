using project_pkdsim.ANIMATOR.NPC.Tsareena.idlebaseanimation;
using project_pkdsim.ANIMATOR.NPC.Tsareena.movementbasedanimations;
using project_pkdsim.ANIMATOR.NPC.Tsareena.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Tsareena.Animator_I
{
	public class LFS_TsareenaFailSafe : MonoBehaviour 
	{
		public Animator Tsareena_Animator;
		public RuntimeAnimatorController someController;

		private Tsareena_CoverterAnimatorController LFSTsareena_AnimatorCCA;
		private Tsareena_AnimatorBaseMovementController LFSTsareena_AnimatorCMA;
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
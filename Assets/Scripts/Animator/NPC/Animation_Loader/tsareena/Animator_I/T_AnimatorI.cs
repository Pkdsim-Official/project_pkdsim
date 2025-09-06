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

		private TsareenaCoverterAnimatorController LFSTsareena_AnimatorCCA;
		private Tsareena_AnimatorBaseMovementController LFSTsareena_AnimatorCMA;
		private TsareenaIdleAnimatorController LFSTsareena_AnimatorICA;


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
			LFSTsareena_AnimatorICA.TIdleAnimatorController();
		}
	}
}
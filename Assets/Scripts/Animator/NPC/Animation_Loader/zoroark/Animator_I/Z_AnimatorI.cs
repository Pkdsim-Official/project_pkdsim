using project_pkdsim.ANIMATOR.Npcs.Zoroark.idlebaseanimation;
using project_pkdsim.ANIMATOR.Npcs.Zoroark.movementbasedanimations;
using project_pkdsim.ANIMATOR.Npcs.Zoroark.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Zoroark.Animator_I
{
	public class LFS_ZoroarkFailSafe : MonoBehaviour 
	{
		public Animator Zoroark_Animator;
		public RuntimeAnimatorController someController;

		private ZoroarkCoverterAnimatorController LFSZoroark_AnimatorCCA;
		private Zoroark_MovementAnimatorController LFSZoroark_AnimatorCMA;
		private Zoroark_IdleAnimatorController LFSZoroark_AnimatorICA;


		public void LoadFailSafeZoroark_AnimatorController()
		{
			LoadFailSafeZoroark_ConvertToAnimatorController();
			LoadFailSafeZoroark_MovementAnimatorController();
			LoadFailSafeZoroark_IdleAnimatorController();
		}
		private void LoadFailSafeZoroark_ConvertToAnimatorController()
		{
			LFSZoroark_AnimatorCCA.ZCoverterToAnimatorController();
		}
		private void LoadFailSafeZoroark_MovementAnimatorController()
		{
			LFSZoroark_AnimatorCMA.ZMovementAnimatorController();
		}
		private void LoadFailSafeZoroark_IdleAnimatorController()
		{
			LFSZoroark_AnimatorICA.Z_IdleAnimatorController();
		}
	}
}
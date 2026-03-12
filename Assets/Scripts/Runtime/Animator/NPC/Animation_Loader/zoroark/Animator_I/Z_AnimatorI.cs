using Project_Pkdsim.ANIMATOR.Npcs.Zoroark.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Npcs.Zoroark.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Npcs.Zoroark.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Zoroark.Animator_I
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
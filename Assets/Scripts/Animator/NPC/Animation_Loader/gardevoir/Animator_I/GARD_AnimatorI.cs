using project_pkdsim.ANIMATOR.NPC.Gardevoir.idlebaseanimation;
using project_pkdsim.ANIMATOR.NPC.Gardevoir.movementbasedanimations;
using project_pkdsim.ANIMATOR.NPC.Gardevoir.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Gardevoir.Animator_I
{
	public class LFS_GardevoirFailSafe : MonoBehaviour 
	{
		public Animator Gardevoir_Animator;
		public RuntimeAnimatorController someController;

		private GardevoirCoverterAnimatorController LFSGardevoir_AnimatorCCA;
		private Gardevoir_AnimatorBaseMovementController LFSGardevoir_AnimatorCMA;
		private Gardevoir_IdleAnimatorController LFSGardevoir_AnimatorICA;


		public void LoadFailSafeGardevoir_AnimatorController()
		{
			LoadFailSafeGardevoir_ConvertToAnimatorController();
			LoadFailSafeGardevoir_MovementAnimatorController();
			LoadFailSafeGardevoir_IdleAnimatorController();
		}
		private void LoadFailSafeGardevoir_ConvertToAnimatorController()
		{
			LFSGardevoir_AnimatorCCA.GARD_CoverterToAnimatorController();
		}
		private void LoadFailSafeGardevoir_MovementAnimatorController()
		{
			LFSGardevoir_AnimatorCMA.GARDMovementAnimatorController();
		}
		private void LoadFailSafeGardevoir_IdleAnimatorController()
		{
			LFSGardevoir_AnimatorICA.GARD_IdleAnimatorController();
		}
	}
}
using Project_Pkdsim.ANIMATOR.Npcs.Gardevoir.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Npcs.Gardevoir.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Npcs.Gardevoir.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Gardevoir.Animator_I
{
	public class LFS_GardevoirFailSafe : MonoBehaviour 
	{
		public Animator Gardevoir_Animator;
		public RuntimeAnimatorController someController;

		private GardevoirCoverterAnimatorController LFSGardevoir_AnimatorCCA;
		private Gardevoir_MovementAnimatorController LFSGardevoir_AnimatorCMA;
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
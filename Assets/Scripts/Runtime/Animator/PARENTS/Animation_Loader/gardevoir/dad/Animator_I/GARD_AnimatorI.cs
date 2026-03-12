using Project_Pkdsim.ANIMATOR.Parents.Gardevoir.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Parents.Gardevoir.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Parents.Gardevoir.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Gardevoir.Animator_I
{
	public class LFS_GardevoirFailSafe : MonoBehaviour 
	{
		public Animator GardevoirParentDad_Animator;
		public RuntimeAnimatorController someController;

		private GardevoirConverterAnimatorController LFSGardevoir_AnimatorCCA;
		private GardevoirParentDad_MovementAnimatorController LFSGardevoir_AnimatorCMA;
		private Gardevoir_IdleAnimatorController LFSGardevoir_AnimatorICA;


		public void LoadFailSafeGardevoir_AnimatorController()
		{
			LoadFailSafeGardevoir_ConvertToAnimatorController();
			LoadFailSafeGardevoir_MovementAnimatorController();
			LoadFailSafeGardevoir_IdleAnimatorController();
		}
		private void LoadFailSafeGardevoir_ConvertToAnimatorController()
		{
			LFSGardevoir_AnimatorCCA.GARD_ConverterAnimatorController();
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
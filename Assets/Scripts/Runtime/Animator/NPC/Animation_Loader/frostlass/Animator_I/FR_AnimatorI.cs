using Project_Pkdsim.ANIMATOR.Npcs.Frostlass.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Npcs.Frostlass.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Npcs.Frostlass.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Frostlass.Animator_I
{
	public class LFS_FrostlassFailSafe : MonoBehaviour 
	{
		public Animator Frostlass_Animator;
		public RuntimeAnimatorController someController;

		private FrostlassCoverterAnimatorController LFSFrostlass_AnimatorCCA;
		private Frostlass_MovementAnimatorController LFSFrostlass_AnimatorCMA;
		private Frostlass_IdleAnimatorController LFSFrostlass_AnimatorICA;


		public void LoadFailSafeFrostlass_AnimatorController()
		{
			LoadFailSafeFrostlass_ConvertToAnimatorController();
			LoadFailSafeFrostlass_MovementAnimatorController();
			LoadFailSafeFrostlass_IdleAnimatorController();
		}
		private void LoadFailSafeFrostlass_ConvertToAnimatorController()
		{
			LFSFrostlass_AnimatorCCA.FRCoverterToAnimatorController();
		}
		private void LoadFailSafeFrostlass_MovementAnimatorController()
		{
			LFSFrostlass_AnimatorCMA.FRMovementAnimatorController();
		}
		private void LoadFailSafeFrostlass_IdleAnimatorController()
		{
			LFSFrostlass_AnimatorICA.FR_IdleAnimatorController();
		}
	}
}
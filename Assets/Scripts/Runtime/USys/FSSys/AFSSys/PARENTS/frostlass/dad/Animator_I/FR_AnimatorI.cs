using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.idlebaseanimation;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.movementbasedanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Animator_I
{
	public class LFS_FrostlassFailSafe : MonoBehaviour 
	{
		public Animator FrostlassParentDad_Animator;
		public RuntimeAnimatorController someController;

		private FrostlassConverterAnimatorController LFSFrostlass_AnimatorCCA;
		private FrostlassParentDad_MovementAnimatorController LFSFrostlass_AnimatorCMA;
		private Frostlass_IdleAnimatorController LFSFrostlass_AnimatorICA;


		public void LoadFailSafeFrostlass_AnimatorController()
		{
			LoadFailSafeFrostlass_ConvertToAnimatorController();
			LoadFailSafeFrostlass_MovementAnimatorController();
			LoadFailSafeFrostlass_IdleAnimatorController();
		}
		private void LoadFailSafeFrostlass_ConvertToAnimatorController()
		{
			LFSFrostlass_AnimatorCCA.FRConverterAnimatorController();
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
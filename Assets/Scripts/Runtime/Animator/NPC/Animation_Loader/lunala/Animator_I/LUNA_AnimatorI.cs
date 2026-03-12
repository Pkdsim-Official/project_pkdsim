using Project_Pkdsim.ANIMATOR.Npcs.Lunala.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Npcs.Lunala.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Npcs.Lunala.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Lunala.Animator_I
{
	public class LFS_LunalaFailSafe : MonoBehaviour 
	{
		public Animator Lunala_Animator;
		public RuntimeAnimatorController someController;

		private LunalaCoverterAnimatorController LFSLunala_AnimatorCCA;
		private Lunala_MovementAnimatorController LFSLunala_AnimatorCMA;
		private Lunala_IdleAnimatorController LFSLunala_AnimatorICA;


		public void LoadFailSafeLunala_AnimatorController()
		{
			LoadFailSafeLunala_ConvertToAnimatorController();
			LoadFailSafeLunala_MovementAnimatorController();
			LoadFailSafeLunala_IdleAnimatorController();
		}
		private void LoadFailSafeLunala_ConvertToAnimatorController()
		{
			LFSLunala_AnimatorCCA.LUNACoverterToAnimatorController();
		}
		private void LoadFailSafeLunala_MovementAnimatorController()
		{
			LFSLunala_AnimatorCMA.LUNAMovementAnimatorController();
		}
		private void LoadFailSafeLunala_IdleAnimatorController()
		{
			LFSLunala_AnimatorICA.LUNA_IdleAnimatorController();
		}
	}
}
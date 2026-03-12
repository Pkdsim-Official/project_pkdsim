using Project_Pkdsim.ANIMATOR.Npcs.Vespiquen.idlebaseanimation;
using Project_Pkdsim.ANIMATOR.Npcs.Vespiquen.movementbasedanimations;
using Project_Pkdsim.ANIMATOR.Npcs.Vespiquen.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Vespiquen.Animator_I
{
	public class LFS_VespiquenFailSafe : MonoBehaviour 
	{
		public Animator Vespiquen_Animator;
		public RuntimeAnimatorController someController;

		private VespiquenCoverterAnimatorController LFSVespiquen_AnimatorCCA;
		private Vespiquen_MovementAnimatorController LFSVespiquen_AnimatorCMA;
		private Vespiquen_IdleAnimatorController LFSVespiquen_AnimatorICA;


		public void LoadFailSafeVespiquen_AnimatorController()
		{
			LoadFailSafeVespiquen_ConvertToAnimatorController();
			LoadFailSafeVespiquen_MovementAnimatorController();
			LoadFailSafeVespiquen_IdleAnimatorController();
		}
		private void LoadFailSafeVespiquen_ConvertToAnimatorController()
		{
			LFSVespiquen_AnimatorCCA.VECoverterToAnimatorController();
		}
		private void LoadFailSafeVespiquen_MovementAnimatorController()
		{
			LFSVespiquen_AnimatorCMA.VEMovementAnimatorController();
		}
		private void LoadFailSafeVespiquen_IdleAnimatorController()
		{
			LFSVespiquen_AnimatorICA.VE_IdleAnimatorController();
		}
	}
}
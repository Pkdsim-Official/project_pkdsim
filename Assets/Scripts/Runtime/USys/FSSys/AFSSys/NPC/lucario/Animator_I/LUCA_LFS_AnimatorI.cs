using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.idlebaseanimation;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.movementbasedanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.Animator_I
{
	public class LFS_LucarioFailSafe : MonoBehaviour 
	{
		public Animator Lucario_Animator;
		public RuntimeAnimatorController someController;

		private Lucario_LFS_CoverterAnimatorController LFSLucario_AnimatorCCA;
		private Lucario_LFS_MovementAnimatorController LFSLucario_AnimatorCMA;
		private Lucario_LFS_IdleAnimatorController LFSLucario_AnimatorICA;


		public void LoadFailSafeLucario_AnimatorController()
		{
			LoadFailSafeLucario_ConvertToAnimatorController();
			LoadFailSafeLucario_MovementAnimatorController();
			LoadFailSafeLucario_IdleAnimatorController();
		}
		private void LoadFailSafeLucario_ConvertToAnimatorController()
		{
			LFSLucario_AnimatorCCA.LUCA_LFS_CoverterToAnimatorController();
		}
		private void LoadFailSafeLucario_MovementAnimatorController()
		{
			LFSLucario_AnimatorCMA.LUCA_LFS_MovementAnimatorController();
		}
		private void LoadFailSafeLucario_IdleAnimatorController()
		{
			LFSLucario_AnimatorICA.LUCA_LFS_IdleAnimatorController();
		}
	}
}
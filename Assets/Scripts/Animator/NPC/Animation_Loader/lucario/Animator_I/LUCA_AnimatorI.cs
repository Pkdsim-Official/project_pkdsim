using project_pkdsim.ANIMATOR.NPC.Lucario.idlebaseanimation;
using project_pkdsim.ANIMATOR.NPC.Lucario.movementbasedanimations;
using project_pkdsim.ANIMATOR.NPC.Lucario.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Lucario.Animator_I
{
	public class LFS_LucarioFailSafe : MonoBehaviour 
	{
		public Animator Lucario_Animator;
		public RuntimeAnimatorController someController;

		private LucarioCoverterAnimatorController LFSLucario_AnimatorCCA;
		private Lucario_AnimatorBaseMovementController LFSLucario_AnimatorCMA;
		private LucarioIdleAnimatorController LFSLucario_AnimatorICA;


		public void LoadFailSafeLucario_AnimatorController()
		{
			LoadFailSafeLucario_ConvertToAnimatorController();
			LoadFailSafeLucario_MovementAnimatorController();
			LoadFailSafeLucario_IdleAnimatorController();
		}
		private void LoadFailSafeLucario_ConvertToAnimatorController()
		{
			LFSLucario_AnimatorCCA.LUCACoverterToAnimatorController();
		}
		private void LoadFailSafeLucario_MovementAnimatorController()
		{
			LFSLucario_AnimatorCMA.LUCAMovementAnimatorController();
		}
		private void LoadFailSafeLucario_IdleAnimatorController()
		{
			LFSLucario_AnimatorICA.LUCAIdleAnimatorController();
		}
	}
}
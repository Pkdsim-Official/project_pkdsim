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

		private Lucario_ConverterToAnimatorController LFSLucario_AnimatorCCA;
		private Lucario_AnimatorMovementController LFSLucario_AnimatorCMA;
		private Lucario_IdleAnimatorController LFSLucario_AnimatorICA;


		public void LoadFailSafeLucario_AnimatorController()
		{
			LoadFailSafeLucario_ConvertToAnimatorController();
			LoadFailSafeLucario_MovementAnimatorController();
			LoadFailSafeLucario_IdleAnimatorController();
		}
		private void LoadFailSafeLucario_ConvertToAnimatorController()
		{
			LFSLucario_AnimatorCCA.LUCA_ConverterToAnimatorController();
		}
		private void LoadFailSafeLucario_MovementAnimatorController()
		{
			LFSLucario_AnimatorCMA.LUCAMovementAnimatorController();
		}
		private void LoadFailSafeLucario_IdleAnimatorController()
		{
			LFSLucario_AnimatorICA.LUCA_IdleAnimatorController();
		}
	}
}
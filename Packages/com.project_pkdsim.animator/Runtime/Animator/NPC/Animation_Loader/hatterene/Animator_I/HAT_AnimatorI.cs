using project_pkdsim.ANIMATOR.NPC.Hatterene.idlebaseanimation;
using project_pkdsim.ANIMATOR.NPC.Hatterene.movementbasedanimations;
using project_pkdsim.ANIMATOR.NPC.Hatterene.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Hatterene.Animator_I
{
	public class LFS_HattereneFailSafe : MonoBehaviour 
	{
		public Animator Hatterene_Animator;
		public RuntimeAnimatorController someController;

		private Hatterene_ConverterAnimatorController LFSHatterene_AnimatorCCA;
		private Hatterene_MovementAnimatorController LFSHatterene_AnimatorCMA;
		private Hatterene_IdleAnimatorController LFSHatterene_AnimatorICA;


		public void LoadFailSafeHatterene_AnimatorController()
		{
			LoadFailSafeHatterene_ConvertToAnimatorController();
			LoadFailSafeHatterene_MovementAnimatorController();
			LoadFailSafeHatterene_IdleAnimatorController();
		}
		private void LoadFailSafeHatterene_ConvertToAnimatorController()
		{
			LFSHatterene_AnimatorCCA.HAT_ConverterAnimatorController();
		}
		private void LoadFailSafeHatterene_MovementAnimatorController()
		{
			LFSHatterene_AnimatorCMA.HAT_MovementAnimatorController();
		}
		private void LoadFailSafeHatterene_IdleAnimatorController()
		{
			LFSHatterene_AnimatorICA.HAT_IdleAnimatorController();
		}
	}
}
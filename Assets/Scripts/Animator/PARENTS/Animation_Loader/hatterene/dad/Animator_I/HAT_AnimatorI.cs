using project_pkdsim.ANIMATOR.Parents.Hatterene.Dad.idlebaseanimation;
using project_pkdsim.ANIMATOR.Parents.Hatterene.Dad.movementbasedanimations;
using project_pkdsim.ANIMATOR.Parents.Hatterene.Dad.converteranimations;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Hatterene.Dad.Animator_I
{
	public class LFS_HattereneFailSafe : MonoBehaviour 
	{
		public Animator HattereneParentDad_Animator;
		public RuntimeAnimatorController someController;

		private HattereneParentDad_ConverterAnimatorController LFSHatterene_AnimatorCCA;
		private HattereneParentDad_MovementAnimatorController LFSHatterene_AnimatorCMA;
		private HattereneParentDad_IdleAnimatorController LFSHatterene_AnimatorICA;


		public void LoadFailSafeHatterene_AnimatorController()
		{
			LoadFailSafeHatterene_ConvertToAnimatorController();
			LoadFailSafeHatterene_MovementAnimatorController();
			LoadFailSafeHatterene_IdleAnimatorController();
		}
		private void LoadFailSafeHatterene_ConvertToAnimatorController()
		{
			LFSHatterene_AnimatorCCA.HATParentDad_ConverterAnimatorController();
		}
		private void LoadFailSafeHatterene_MovementAnimatorController()
		{
			LFSHatterene_AnimatorCMA.HATParentDad_MovementAnimatorController();
		}
		private void LoadFailSafeHatterene_IdleAnimatorController()
		{
			LFSHatterene_AnimatorICA.HATParentDad_IdleAnimatorController();
		}
	}
}
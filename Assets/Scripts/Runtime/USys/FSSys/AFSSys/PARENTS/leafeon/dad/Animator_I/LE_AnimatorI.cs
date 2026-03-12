using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.movementbasedanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.converteranimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.idlebaseanimation;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.Animator_I
{
	public class LE_AnimatorI : MonoBehaviour
	{
		public Animator LeafeonParentDad_Animator;
		public RuntimeAnimatorController someController;

		private LeafeonParentDad_ConverterAnimatorController LFSLeafeon_AnimatorCCA;
		private LeafeonParentDad_MovementAnimatorController LFSLeafeon_AnimatorCMA;
		private LeafeonParentDad_IdleAnimatorController LFSLeafeon_AnimatorICA;

		public void LoadFailSafeLeafeon_AnimatorController()
		{
			LoadFailSafeLeafeon_ConvertToAnimatorController();
			LoadFailSafeLeafeon_MovementAnimatorController();
			LoadFailSafeLeafeon_IdleAnimatorController();
		}
		private void LoadFailSafeLeafeon_ConvertToAnimatorController()
		{
			LFSLeafeon_AnimatorCCA.LEParentDad_ConverterAnimatorController();
		}
		private void LoadFailSafeLeafeon_MovementAnimatorController()
		{
			LFSLeafeon_AnimatorCMA.LEParentDad_MovementAnimatorController();
		}
		private void LoadFailSafeLeafeon_IdleAnimatorController()
		{
			LFSLeafeon_AnimatorICA.LEParentDad_IdleAnimatorController();
		}
	}
}
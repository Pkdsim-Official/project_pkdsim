using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.idlebaseanimation;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.movementbasedanimations;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.converteranimations;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.Animator_I
{
	public class LFS_LeafeonFailSafe : MonoBehaviour 
	{
		private LeafeonParentMom_ConverterAnimatorController LFSLeafeon_AnimatorCCA;
		private LeafeonParentMom_MovementAnimatorController LFSLeafeon_AnimatorCMA;
		private LeafeonParentMom_IdleAnimatorController LFSLeafeon_AnimatorICA;

		public void LoadFailSafeLeafeon_AnimatorController()
		{
			LoadFailSafeLeafeon_ConvertToAnimatorController();
			LoadFailSafeLeafeon_MovementAnimatorController();
			LoadFailSafeLeafeon_IdleAnimatorController();
		}
		private void LoadFailSafeLeafeon_ConvertToAnimatorController()
		{
			LFSLeafeon_AnimatorCCA.LEParentMom_ConverterAnimatorController();
		}
		private void LoadFailSafeLeafeon_MovementAnimatorController()
		{
			LFSLeafeon_AnimatorCMA.LEParentMom_MovementAnimatorController();
		}
		private void LoadFailSafeLeafeon_IdleAnimatorController()
		{
			LFSLeafeon_AnimatorICA.LEParentMom_IdleAnimatorController();
		}
	}
}
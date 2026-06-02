using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.movementbasedanimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.converteranimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.idlebaseanimation;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.Animator_I
{
	public class LeafeonParentDad_FailSafe : MonoBehaviour 
	{
		public Animator LeafeonParentDad_Animator;
		public RuntimeAnimatorController someController;

		private LeafeonParentDad_ConverterAnimatorController LeafeonParentDad_AnimatorCCA;
		private LeafeonParentDad_MovementAnimatorController LeafeonParentDad_AnimatorCMA;
		private LeafeonParentDad_IdleAnimatorController  LeafeonParentDad_AnimatorICA;

		public void LoadFailSafeLeafeonParentDad_AnimatorController()
		{
			LeafeonParentDad_ConvertToAnimatorController();
			LeafeonParentDad_MovementAnimatorController();
			LeafeonParentDad_IdleAnimatorController();
		}
		private void LeafeonParentDad_ConvertToAnimatorController()
		{
			LeafeonParentDad_AnimatorCCA.LEParentDad_ConverterAnimatorController();
		}
		private void LeafeonParentDad_MovementAnimatorController()
		{
			LeafeonParentDad_AnimatorCMA.LEParentDad_MovementAnimatorController();
		}
		private void LeafeonParentDad_IdleAnimatorController()
		{
			LeafeonParentDad_AnimatorICA.LEParentDad_IdleAnimatorController();
		}
	}
}

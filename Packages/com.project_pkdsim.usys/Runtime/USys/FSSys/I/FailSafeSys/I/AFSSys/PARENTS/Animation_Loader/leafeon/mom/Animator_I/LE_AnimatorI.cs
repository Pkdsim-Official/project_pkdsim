using  project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.movementbasedanimations;
using  project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.converteranimations;
using  project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.idlebaseanimation;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.Animator_I
{
	public class LeafeonParentMom_FailSafe : MonoBehaviour 
	{
		public Animator LeafeonParentMom_Animator;
		public RuntimeAnimatorController someController;

		private LeafeonParentMom_ConverterAnimatorController LeafeonParentMom_AnimatorCCA;
		private LeafeonParentMom_MovementAnimatorController LeafeonParentMom_AnimatorCMA;
		private LeafeonParentMom_IdleAnimatorController  LeafeonParentMom_AnimatorICA;

		public void LoadFailSafeLeafeonParentMom_AnimatorController()
		{
			LeafeonParentMom_ConvertToAnimatorController();
			LeafeonParentMom_MovementAnimatorController();
			LeafeonParentMom_IdleAnimatorController();	
		}
		private void  LeafeonParentMom_ConvertToAnimatorController()
		{

		}
		private void LeafeonParentMom_MovementAnimatorController()
		{
			
		}
		private void LeafeonParentMom_IdleAnimatorController()
		{
			
		}
	}
}
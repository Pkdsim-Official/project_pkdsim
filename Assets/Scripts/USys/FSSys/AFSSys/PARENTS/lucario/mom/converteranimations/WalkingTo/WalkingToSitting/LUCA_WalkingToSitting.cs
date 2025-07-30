using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class LUCAParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator lucarioParentMom_Animator;
		public void LUCAParentMom_WalkingToSittingController()
		{
			lucarioParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			lucarioParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}
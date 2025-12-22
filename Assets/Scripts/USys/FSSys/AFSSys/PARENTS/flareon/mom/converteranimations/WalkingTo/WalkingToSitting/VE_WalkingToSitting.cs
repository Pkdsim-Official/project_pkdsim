using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class FLParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator FlareonParentMom_Animator;
		public void FLParentMom_WalkingToSittingController()
		{
			FlareonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FlareonParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}
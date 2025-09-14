using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class SYLParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator SylveonParentMom_Animator;
		public void SYLParentMom_WalkingToSittingController()
		{
			SylveonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			SylveonParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}
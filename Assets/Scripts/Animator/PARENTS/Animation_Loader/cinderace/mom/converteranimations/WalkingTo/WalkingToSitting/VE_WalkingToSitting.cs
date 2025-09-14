using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Cinderace.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class CParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator CinderaceParentMom_Animator;
		public void CParentMom_WalkingToSittingController()
		{
			CinderaceParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			CinderaceParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}
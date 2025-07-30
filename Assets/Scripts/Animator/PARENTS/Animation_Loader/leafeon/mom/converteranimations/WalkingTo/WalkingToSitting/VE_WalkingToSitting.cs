using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class LEParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator LeafeonParentMom_Animator;
		public void LEParentMom_WalkingToSittingController()
		{
			LeafeonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LeafeonParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}
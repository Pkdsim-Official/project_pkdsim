using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Garchomp.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class GARCParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator GarchompParentMom_Animator;
		public void GARCParentMom_WalkingToSittingController()
		{
			GarchompParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GarchompParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}
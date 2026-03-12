using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Jolteon.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class JTParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator JolteonParentMom_Animator;
		public void JTParentMom_WalkingToSittingController()
		{
			JolteonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			JolteonParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}
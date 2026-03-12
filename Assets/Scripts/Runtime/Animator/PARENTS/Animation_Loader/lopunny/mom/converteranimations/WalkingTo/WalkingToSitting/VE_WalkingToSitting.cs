using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Lopunny.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class LOParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator LopunnyParentMom_Animator;
		public void LOParentMom_WalkingToSittingController()
		{
			LopunnyParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LopunnyParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}
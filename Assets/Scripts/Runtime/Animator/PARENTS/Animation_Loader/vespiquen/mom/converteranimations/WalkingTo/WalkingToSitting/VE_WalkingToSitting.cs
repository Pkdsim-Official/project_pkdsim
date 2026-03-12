using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class VEParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator VespiquenParentMom_Animator;
		public void VEParentMom_WalkingToSittingController()
		{
			VespiquenParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			VespiquenParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}
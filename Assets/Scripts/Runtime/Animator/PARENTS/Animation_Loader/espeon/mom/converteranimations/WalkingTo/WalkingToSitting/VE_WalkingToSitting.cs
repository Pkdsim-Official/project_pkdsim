using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Espeon.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class ESParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator EspeonParentMom_Animator;
		public void ESParentMom_WalkingToSittingController()
		{
			EspeonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			EspeonParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}
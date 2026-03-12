using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Noivern.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class NOIParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator NoivernParentMom_Animator;
		public void NOIParentMom_WalkingToSittingController()
		{
			NoivernParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			NoivernParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}
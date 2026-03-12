using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Delphox.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class DLParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator DelphoxParentMom_Animator;
		public void DLParentMom_WalkingToSittingController()
		{
			DelphoxParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			DelphoxParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}
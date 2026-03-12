using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class MEOWParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator MeowscaradaParentMom_Animator;
		public void MEOWParentMom_WalkingToSittingController()
		{
			MeowscaradaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			MeowscaradaParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}
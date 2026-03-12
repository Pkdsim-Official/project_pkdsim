using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class PHParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator PheromosaParentMom_Animator;
		public void PHParentMom_WalkingToSittingController()
		{
			PheromosaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			PheromosaParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Vespiquen.converteranimations.WalkingTo.WalkingToSitting
{
	public class VEWalkingToSitting : MonoBehaviour 
	{
		private Animator Vespiquen_Animator;
		public void VEWalkingToSittingController()
		{
			Vespiquen_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vespiquen_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}
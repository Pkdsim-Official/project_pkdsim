using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Vespiquen.converteranimations.WalkingTo.WalkingToSitting
{
	public class VE_WalkingToSitting : MonoBehaviour 
	{
		private Animator Vespiquen_Animator;
		public void VE_WalkingToSittingController()
		{
			Vespiquen_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vespiquen_Animator.Play("_WalkingTo_Sitting");         // Start in the _WalkingTo animation state
		}
	}
}
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class VEIdleToWalk : MonoBehaviour 
	{
		private Animator Vespiquen_Animator;
		public void VEIdleToWalkController()
		{
			Vespiquen_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vespiquen_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}
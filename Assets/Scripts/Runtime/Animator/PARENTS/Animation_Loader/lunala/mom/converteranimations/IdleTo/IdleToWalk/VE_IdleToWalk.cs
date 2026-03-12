using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Lunala.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class LUNAParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator LunalaParentMom_Animator;
		public void LUNAParentMom_IdleToWalkController()
		{
			LunalaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LunalaParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}
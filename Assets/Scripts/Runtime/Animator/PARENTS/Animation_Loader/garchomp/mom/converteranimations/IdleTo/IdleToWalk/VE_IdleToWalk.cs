using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Garchomp.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class GARCParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator GarchompParentMom_Animator;
		public void GARCParentMom_IdleToWalkController()
		{
			GarchompParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GarchompParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}
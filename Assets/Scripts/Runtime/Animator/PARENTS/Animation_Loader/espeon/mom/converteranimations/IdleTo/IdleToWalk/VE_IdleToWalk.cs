using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Espeon.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class ESParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator EspeonParentMom_Animator;
		public void ESParentMom_IdleToWalkController()
		{
			EspeonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			EspeonParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}
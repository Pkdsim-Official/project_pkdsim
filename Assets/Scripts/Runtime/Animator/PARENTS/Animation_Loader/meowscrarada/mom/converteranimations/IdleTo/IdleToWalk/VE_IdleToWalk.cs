using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class MEOWParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator MeowscaradaParentMom_Animator;
		public void MEOWParentMom_IdleToWalkController()
		{
			MeowscaradaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			MeowscaradaParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}
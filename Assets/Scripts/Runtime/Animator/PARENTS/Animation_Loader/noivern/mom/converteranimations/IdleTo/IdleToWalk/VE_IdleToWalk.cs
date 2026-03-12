using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Noivern.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class NOIParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator NoivernParentMom_Animator;
		public void NOIParentMom_IdleToWalkController()
		{
			NoivernParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			NoivernParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}
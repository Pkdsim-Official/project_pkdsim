using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Delphox.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class DLParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator DelphoxParentMom_Animator;
		public void DLParentMom_IdleToWalkController()
		{
			DelphoxParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			DelphoxParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}
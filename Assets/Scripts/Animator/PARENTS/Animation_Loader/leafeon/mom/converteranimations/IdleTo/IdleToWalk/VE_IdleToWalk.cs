using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class LEParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator LeafeonParentMom_Animator;
		public void LEParentMom_IdleToWalkController()
		{
			LeafeonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LeafeonParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}
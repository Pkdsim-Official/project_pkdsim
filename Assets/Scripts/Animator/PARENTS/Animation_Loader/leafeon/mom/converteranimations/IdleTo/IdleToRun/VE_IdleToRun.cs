using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.converteranimations.IdleTo.IdleToRun
{
	public class LEParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator LeafeonParentMom_Animator;
		public void LEParentMom_IdleToRunController()
		{
			LeafeonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LeafeonParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}
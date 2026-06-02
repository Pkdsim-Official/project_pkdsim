using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.idlebaseanimation.IdleSitting
{
	public class LEParent_IdleSitting : MonoBehaviour 
	{
		public Animator LeafeonParentMom_Animator;
		public void LEParent_IdleSittingController()
		{
			LeafeonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LeafeonParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
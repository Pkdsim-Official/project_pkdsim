using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.idlebaseanimation.IdleSitting
{
	public class LEParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator LeafeonParentMom_Animator;
		public void LEParentMom_IdleSittingController()
		{
			LeafeonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LeafeonParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
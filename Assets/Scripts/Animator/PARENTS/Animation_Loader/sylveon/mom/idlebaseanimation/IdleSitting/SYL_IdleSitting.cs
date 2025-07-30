using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.idlebaseanimation.IdleSitting
{
	public class SYLParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator SylveonParentMom_Animator;
		public void SYLParentMom_IdleSittingController()
		{
			SylveonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			SylveonParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
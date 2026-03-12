using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Sylveon.Mom.converteranimations.IdleTo.IdleToRun
{
	public class SYLParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator SylveonParentMom_Animator;
		public void SYLParentMom_IdleToRunController()
		{
			SylveonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			SylveonParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}
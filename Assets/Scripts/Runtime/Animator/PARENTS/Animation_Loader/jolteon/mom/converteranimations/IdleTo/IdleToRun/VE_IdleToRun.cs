using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Jolteon.Mom.converteranimations.IdleTo.IdleToRun
{
	public class JTParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator JolteonParentMom_Animator;
		public void JTParentMom_IdleToRunController()
		{
			JolteonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			JolteonParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}
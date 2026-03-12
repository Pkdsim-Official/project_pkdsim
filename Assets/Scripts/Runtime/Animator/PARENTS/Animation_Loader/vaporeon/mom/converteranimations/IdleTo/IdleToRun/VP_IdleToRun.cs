using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.IdleTo.IdleToRun
{
	public class VPParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator VaporeonParentMom_Animator;
		public void VPParentMom_IdleToRunController()
		{
			VaporeonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			VaporeonParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}
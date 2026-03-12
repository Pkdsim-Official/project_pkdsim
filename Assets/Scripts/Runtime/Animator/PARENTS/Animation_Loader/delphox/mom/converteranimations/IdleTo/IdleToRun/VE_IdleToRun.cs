using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Delphox.Mom.converteranimations.IdleTo.IdleToRun
{
	public class DLParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator DelphoxParentMom_Animator;
		public void DLParentMom_IdleToRunController()
		{
			DelphoxParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			DelphoxParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}
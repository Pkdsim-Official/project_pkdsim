using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Espeon.Mom.converteranimations.IdleTo.IdleToRun
{
	public class ESParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator EspeonParentMom_Animator;
		public void ESParentMom_IdleToRunController()
		{
			EspeonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			EspeonParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}
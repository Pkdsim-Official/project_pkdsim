using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Absol.Mom.converteranimations.IdleTo.IdleToRun
{
	public class ABParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator AbsolParentMom_Animator;
		public void ABParentMom_IdleToRunController()
		{
			AbsolParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			AbsolParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}
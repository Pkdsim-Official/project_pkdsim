using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Gardevoir.Mom.converteranimations.IdleTo.IdleToRun
{
	public class GARDParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator GardevoirParentMom_Animator;
		public void GARDParentMom_IdleToRunController()
		{
			GardevoirParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GardevoirParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}
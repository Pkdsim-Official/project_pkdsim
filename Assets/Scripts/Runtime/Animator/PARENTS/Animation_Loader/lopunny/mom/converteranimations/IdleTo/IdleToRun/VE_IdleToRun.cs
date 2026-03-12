using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Lopunny.Mom.converteranimations.IdleTo.IdleToRun
{
	public class LOParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator LopunnyParentMom_Animator;
		public void LOParentMom_IdleToRunController()
		{
			LopunnyParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LopunnyParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lopunny.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class LOParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator LopunnyParentMom_Animator;
		public void LOParentMom_IdleToWalkController()
		{
			LopunnyParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LopunnyParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}
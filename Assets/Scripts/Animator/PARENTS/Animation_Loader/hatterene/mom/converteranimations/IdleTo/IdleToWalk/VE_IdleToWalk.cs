using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Hatterene.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class HATParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator HattereneParentMom_Animator;
		public void HATParentMom_IdleToWalkController()
		{
			HattereneParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			HattereneParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}
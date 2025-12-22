using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class CParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator CinderaceParentMom_Animator;
		public void CParentMom_IdleToWalkController()
		{
			CinderaceParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			CinderaceParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}
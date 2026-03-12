using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.converteranimations.IdleTo.IdleToRun
{
	public class CParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator CinderaceParentMom_Animator;
		public void CParentMom_IdleToRunController()
		{
			CinderaceParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			CinderaceParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}
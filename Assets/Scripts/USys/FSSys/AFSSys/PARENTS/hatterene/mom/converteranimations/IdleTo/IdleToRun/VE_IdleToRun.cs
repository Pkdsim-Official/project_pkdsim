using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.converteranimations.IdleTo.IdleToRun
{
	public class HATParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator HattereneParentMom_Animator;
		public void HATParentMom_IdleToRunController()
		{
			HattereneParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			HattereneParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}
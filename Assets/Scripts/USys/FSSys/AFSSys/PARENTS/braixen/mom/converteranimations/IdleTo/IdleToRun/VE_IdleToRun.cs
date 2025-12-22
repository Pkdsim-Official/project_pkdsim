using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Mom.converteranimations.IdleTo.IdleToRun
{
	public class BRParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator BraixenParentMom_Animator;
		public void BRParentMom_IdleToRunController()
		{
			BraixenParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BraixenParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}
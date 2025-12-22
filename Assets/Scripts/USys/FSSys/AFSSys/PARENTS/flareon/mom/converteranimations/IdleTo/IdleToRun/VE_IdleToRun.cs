using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Mom.converteranimations.IdleTo.IdleToRun
{
	public class FLParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator FlareonParentMom_Animator;
		public void FLParentMom_IdleToRunController()
		{
			FlareonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FlareonParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}
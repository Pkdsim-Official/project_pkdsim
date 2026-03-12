using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.converteranimations.IdleTo.IdleToRun
{
	public class BEParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator BeedrillParentMom_Animator;
		public void BEParentMom_IdleToRunController()
		{
			BeedrillParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BeedrillParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}
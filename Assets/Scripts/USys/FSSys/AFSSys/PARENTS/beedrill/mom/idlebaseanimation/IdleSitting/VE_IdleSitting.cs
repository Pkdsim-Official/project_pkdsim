using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.idlebaseanimation.IdleSitting
{
	public class BEParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator BeedrillParentMom_Animator;
		public void BEParentMom_IdleSittingController()
		{
			BeedrillParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BeedrillParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
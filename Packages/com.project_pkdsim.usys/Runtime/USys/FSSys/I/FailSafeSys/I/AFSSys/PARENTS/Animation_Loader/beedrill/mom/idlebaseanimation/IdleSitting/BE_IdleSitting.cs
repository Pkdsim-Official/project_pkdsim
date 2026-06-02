using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.idlebaseanimation.IdleSitting
{
	public class BE_IdleSitting : MonoBehaviour 
	{
		private Animator BeedrillParentMom_Animator;
		public void BE_IdleSittingController()
		{
			BeedrillParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BeedrillParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
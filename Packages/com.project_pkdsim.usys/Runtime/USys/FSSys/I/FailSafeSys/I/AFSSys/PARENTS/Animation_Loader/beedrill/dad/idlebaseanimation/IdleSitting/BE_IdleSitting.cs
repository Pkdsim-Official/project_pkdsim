using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.idlebaseanimation.IdleSitting
{
	public class BE_IdleSitting : MonoBehaviour 
	{
		private Animator BeedrillParentDad_Animator;
		public void BE_IdleSittingController()
		{
			BeedrillParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BeedrillParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
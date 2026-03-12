using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.idlebaseanimation.IdleSitting
{
	public class BEParentDad_IdleSitting : MonoBehaviour 
	{
		private Animator BeedrillParentDad_Animator;
		public void BEParentDad_IdleSittingController()
		{
			BeedrillParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BeedrillParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
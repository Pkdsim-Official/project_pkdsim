using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Dad.idlebaseanimation.IdleSitting
{
	public class BL_IdleSitting : MonoBehaviour 
	{
		private Animator BlazikenParentDad_Animator;
		public void BL_IdleSittingController()
		{
			BlazikenParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BlazikenParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
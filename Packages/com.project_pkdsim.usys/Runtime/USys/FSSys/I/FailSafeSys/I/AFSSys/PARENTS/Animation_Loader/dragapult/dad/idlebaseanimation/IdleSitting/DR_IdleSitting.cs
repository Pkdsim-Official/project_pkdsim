using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.idlebaseanimation.IdleSitting
{
	public class DRParentDad_IdleSitting : MonoBehaviour 
	{
		private Animator DelphoxParentDad_Animator;
		public void DRParentDad_IdleSittingController()
		{
			DelphoxParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			DelphoxParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
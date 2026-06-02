using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.idlebaseanimation.IdleStanding
{
	public class DRParentDad_IdleStanding : MonoBehaviour 
	{
		public Animator DelphoxParentDad_Animator;
		public void DRParentDad_IdleStandingController()
		{
			// Assign the idle animation clip
			DelphoxParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			DelphoxParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}
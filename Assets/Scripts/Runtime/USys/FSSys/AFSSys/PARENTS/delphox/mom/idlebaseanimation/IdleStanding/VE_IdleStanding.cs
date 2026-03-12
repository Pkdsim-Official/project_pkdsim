using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.idlebaseanimation.IdleStanding
{
	public class DLParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator DelphoxParentMom_Animator;
		public void DLParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			DelphoxParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			DelphoxParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}
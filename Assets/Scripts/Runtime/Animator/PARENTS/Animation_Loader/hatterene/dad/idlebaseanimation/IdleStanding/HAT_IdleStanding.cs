using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Hatterene.Dad.idlebaseanimation.IdleStanding
{
	public class HATParentDad_IdleStanding : MonoBehaviour 
	{
		public Animator HattereneParentDad_Animator;
		public void HATParentDad_IdleStandingController()
		{
			// Assign the idle animation clip
			HattereneParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			HattereneParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}
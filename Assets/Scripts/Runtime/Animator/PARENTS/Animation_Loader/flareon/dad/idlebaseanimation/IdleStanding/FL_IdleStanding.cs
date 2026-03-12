using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Flareon.Dad.idlebaseanimation.IdleStanding
{
	public class FLParentDadDad_IdleStanding : MonoBehaviour 
	{
		public Animator FlareonParentDad_Animator;
		public void FLParentDadDad_IdleStandingController()
		{
			// Assign the idle animation clip
			FlareonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FlareonParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}
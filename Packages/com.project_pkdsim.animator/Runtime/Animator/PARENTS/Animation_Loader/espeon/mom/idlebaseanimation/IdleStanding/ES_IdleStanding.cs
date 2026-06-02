using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Espeon.Mom.idlebaseanimation.IdleStanding
{
	public class ES_IdleStanding : MonoBehaviour 
	{
		public Animator EspeonParentMom_Animator;
		public void ES_IdleStandingController()
		{
			EspeonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			EspeonParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}

	}
}
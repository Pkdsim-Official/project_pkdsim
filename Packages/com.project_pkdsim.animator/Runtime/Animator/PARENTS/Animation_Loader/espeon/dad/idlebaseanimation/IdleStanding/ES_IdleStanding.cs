using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Espeon.Dad.idlebaseanimation.IdleStanding
{
	public class ES_IdleStanding : MonoBehaviour 
	{
		public Animator EspeonParentDad_Animator;
		public void ES_IdleStandingController()
		{
			EspeonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			EspeonParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}

	}
}
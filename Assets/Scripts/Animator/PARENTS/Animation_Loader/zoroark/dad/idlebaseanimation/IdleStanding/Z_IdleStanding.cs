using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Zoroark.Dad.idlebaseanimation.IdleStanding
{
	public class ZParentDad_IdleStanding : MonoBehaviour 
	{
		public Animator ZoroarkParentDad_Animator;
		public void ZParentDad_IdleStandingController()
		{
			// Assign the idle animation clip
			ZoroarkParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			ZoroarkParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}
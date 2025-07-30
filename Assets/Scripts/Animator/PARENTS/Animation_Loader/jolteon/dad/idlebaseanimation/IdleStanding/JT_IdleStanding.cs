using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.idlebaseanimation.IdleStanding
{
	public class JTParentDad_IdleStanding : MonoBehaviour 
	{
		public Animator JolteonParentDad_Animator;
		public void JTParentDad_IdleStandingController()
		{
			JolteonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			JolteonParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}
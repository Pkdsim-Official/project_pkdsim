using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Sylveon.Dad.idlebaseanimation.IdleStanding
{
	public class SYLParentDad_IdleStanding : MonoBehaviour 
	{
		public Animator SylveonParentDad_Animator;
		public void SYLParentDad_IdleStandingController()
		{
			SylveonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			SylveonParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}
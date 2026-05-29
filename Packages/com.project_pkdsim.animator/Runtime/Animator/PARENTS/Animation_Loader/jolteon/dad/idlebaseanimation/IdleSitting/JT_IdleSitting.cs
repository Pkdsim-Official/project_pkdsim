using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.idlebaseanimation.IdleSitting
{
	public class JT_IdleSitting : MonoBehaviour 
	{
		public Animator JolteonParent_Animator;
		public void JT_IdleSittingController()
		{
			JolteonParent_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			JolteonParent_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
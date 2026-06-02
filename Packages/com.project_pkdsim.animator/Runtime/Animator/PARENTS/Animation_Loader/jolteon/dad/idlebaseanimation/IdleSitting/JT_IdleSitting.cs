using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.idlebaseanimation.IdleSitting
{
	public class JTParentDad_IdleSitting : MonoBehaviour 
	{
		public Animator JolteonParentDad_Animator;
		public void JTParentDad_IdleSittingController()
		{
			JolteonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			JolteonParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
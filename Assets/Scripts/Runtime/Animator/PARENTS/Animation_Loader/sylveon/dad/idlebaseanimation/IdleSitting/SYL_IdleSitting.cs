using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Sylveon.Dad.idlebaseanimation.IdleSitting
{
	public class SYLParentDad_IdleSitting : MonoBehaviour 
	{
		public Animator SylveonParentDad_Animator;
		public void SYLParentDad_IdleSittingController()
		{
			SylveonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			SylveonParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
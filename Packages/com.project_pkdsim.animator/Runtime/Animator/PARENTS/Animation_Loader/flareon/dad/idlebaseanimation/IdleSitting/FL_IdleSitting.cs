using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.idlebaseanimation.IdleSitting
{
	public class FL_IdleSitting : MonoBehaviour 
	{
		public Animator FlareonParentDad_Animator;
		public void FL_IdleSittingController()
		{
			FlareonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FlareonParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
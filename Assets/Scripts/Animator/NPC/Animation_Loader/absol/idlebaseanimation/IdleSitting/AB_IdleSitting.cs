using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Absol.idlebaseanimation.IdleSitting
{
	public class AB_IdleSitting : MonoBehaviour 
	{
		private Animator Absol_Animator;
		public void AB_IdleSittingController()
		{
			Absol_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Absol_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
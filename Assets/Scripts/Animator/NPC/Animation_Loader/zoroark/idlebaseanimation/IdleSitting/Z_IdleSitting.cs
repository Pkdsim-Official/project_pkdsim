using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Zoroark.idlebaseanimation.IdleSitting
{
	public class ZIdleSitting : MonoBehaviour 
	{
		private Animator Zoroark_Animator;
		public void ZIdleSittingController()
		{
			Zoroark_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Zoroark_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
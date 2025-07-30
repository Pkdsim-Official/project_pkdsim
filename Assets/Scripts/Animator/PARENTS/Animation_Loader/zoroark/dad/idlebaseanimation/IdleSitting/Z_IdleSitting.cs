using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Zoroark.Dad.idlebaseanimation.IdleSitting
{
	public class ZParentDad_IdleSitting : MonoBehaviour 
	{
		private Animator Zoroark_Animator;
		public void ZParentDad_IdleSittingController()
		{
			Zoroark_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Zoroark_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
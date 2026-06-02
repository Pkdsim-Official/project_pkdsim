using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Hatterene.idlebaseanimation.IdleSitting
{
	public class HAT_IdleSitting : MonoBehaviour 
	{
		private Animator Hatterene_Animator;
		public void HAT_IdleSittingController()
		{
			Hatterene_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Hatterene_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
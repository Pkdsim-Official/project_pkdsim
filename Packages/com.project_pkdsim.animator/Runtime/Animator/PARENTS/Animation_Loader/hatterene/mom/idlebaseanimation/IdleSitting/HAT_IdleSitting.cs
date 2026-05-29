using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Hatterene.Mom.idlebaseanimation.IdleSitting
{
	public class HATIdleSitting : MonoBehaviour 
	{
		private Animator Hatterene_Animator;
		public void HATIdleSittingController()
		{
			Hatterene_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Hatterene_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
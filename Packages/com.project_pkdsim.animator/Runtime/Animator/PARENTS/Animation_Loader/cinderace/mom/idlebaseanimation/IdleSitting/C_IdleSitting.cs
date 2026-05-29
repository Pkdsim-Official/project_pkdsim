using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Cinderace.Mom.idlebaseanimation.IdleSitting
{
	public class C_IdleSitting : MonoBehaviour 
	{
		private Animator CinderaceParentMom_Animator;
		public void C_IdleSittingController()
		{
			CinderaceParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			CinderaceParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
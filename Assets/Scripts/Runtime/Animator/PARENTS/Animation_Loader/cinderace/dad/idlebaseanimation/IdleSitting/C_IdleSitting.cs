using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Cinderace.Dad.idlebaseanimation.IdleSitting
{
	public class CParentDad_IdleSitting : MonoBehaviour 
	{
		private Animator CinderaceParentDad_Animator;
		public void CParentDad_IdleSittingController()
		{
			CinderaceParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			CinderaceParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
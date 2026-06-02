using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Espeon.Mom.idlebaseanimation.IdleSitting
{
	public class ES_IdleSitting : MonoBehaviour 
	{
		public Animator EspeonParentMom_Animator;
		public void ES_IdleSittingController()
		{
			EspeonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			EspeonParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
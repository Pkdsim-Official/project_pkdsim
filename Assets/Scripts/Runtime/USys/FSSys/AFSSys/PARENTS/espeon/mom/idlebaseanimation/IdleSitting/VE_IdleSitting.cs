using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.idlebaseanimation.IdleSitting
{
	public class ESParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator EspeonParentMom_Animator;
		public void ESParentMom_IdleSittingController()
		{
			EspeonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			EspeonParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
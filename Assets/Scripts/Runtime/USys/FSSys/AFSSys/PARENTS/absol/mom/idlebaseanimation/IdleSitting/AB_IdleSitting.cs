using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.idlebaseanimation.IdleSitting
{
	public class ABParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator AbsolParentMom_Animator;
		public void ABParentMom_IdleSittingController()
		{
			AbsolParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			AbsolParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
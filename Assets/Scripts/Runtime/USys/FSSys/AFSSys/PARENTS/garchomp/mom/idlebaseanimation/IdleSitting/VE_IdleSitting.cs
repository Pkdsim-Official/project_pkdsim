using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.idlebaseanimation.IdleSitting
{
	public class GARCParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator GarchompParentMom_Animator;
		public void GARCParentMom_IdleSittingController()
		{
			GarchompParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GarchompParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
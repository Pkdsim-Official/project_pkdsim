using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.idlebaseanimation.IdleSitting
{
	public class GARDParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator GardevoirParentMom_Animator;
		public void GARDParentMom_IdleSittingController()
		{
			GardevoirParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GardevoirParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Lunala.Mom.idlebaseanimation.IdleSitting
{
	public class LUNAParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator LunalaParentMom_Animator;
		public void LUNAParentMom_IdleSittingController()
		{
			LunalaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LunalaParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
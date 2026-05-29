using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.idlebaseanimation.IdleSitting
{
	public class FRIdleSitting : MonoBehaviour 
	{
		private Animator FrostlassParentMom_Animator;
		public void FRIdleSittingController()
		{
			FrostlassParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FrostlassParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
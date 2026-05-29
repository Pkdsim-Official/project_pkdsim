using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Gardevoir.Mom.idlebaseanimation.IdleSitting
{
	public class GARDIdleSitting : MonoBehaviour 
	{
		private Animator GardevoirParentMom_Animator;
		public void GARDIdleSittingController()
		{
			GardevoirParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GardevoirParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
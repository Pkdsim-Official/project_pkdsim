using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Zoroark.Mom.idlebaseanimation.IdleSitting
{
	public class ZParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator ZoroarkParentMom_Animator;
		public void ZParentMom_IdleSittingController()
		{
			ZoroarkParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			ZoroarkParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
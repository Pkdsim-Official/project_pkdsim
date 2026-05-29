using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lunala.Mom.idlebaseanimation.IdleSitting
{
	public class LUNAIdleSitting : MonoBehaviour 
	{
		private Animator FlareonParentMom_Animator;
		public void LUNAIdleSittingController()
		{
			FlareonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FlareonParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
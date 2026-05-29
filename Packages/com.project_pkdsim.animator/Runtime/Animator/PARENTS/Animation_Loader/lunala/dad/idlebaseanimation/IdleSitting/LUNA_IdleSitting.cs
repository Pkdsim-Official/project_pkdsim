using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lunala.Dad.idlebaseanimation.IdleSitting
{
	public class LUNAIdleSitting : MonoBehaviour 
	{
		private Animator FlareonParentDad_Animator;
		public void LUNAIdleSittingController()
		{
			FlareonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FlareonParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
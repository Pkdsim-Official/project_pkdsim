using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Garchomp.Dad.idlebaseanimation.IdleSitting
{
	public class GARC_IdleSitting : MonoBehaviour 
	{
		private Animator FlareonParentDad_Animator;
		public void GARC_IdleSittingController()
		{
			FlareonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FlareonParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
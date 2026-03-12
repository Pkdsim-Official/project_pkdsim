using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.idlebaseanimation.IdleSitting
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
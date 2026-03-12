using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Dad.idlebaseanimation.IdleSitting
{
	public class BRParentDad_IdleSitting : MonoBehaviour 
	{
		private Animator BraixenParentDad_Animator;
		public void BRParentDad_IdleSittingController()
		{
			BraixenParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BraixenParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
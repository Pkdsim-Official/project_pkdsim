using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.IdleTo.IdleToRun
{
	public class LUNAParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator LunalaParentMom_Animator;
		public void LUNAParentMom_IdleToRunController()
		{
			LunalaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LunalaParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}
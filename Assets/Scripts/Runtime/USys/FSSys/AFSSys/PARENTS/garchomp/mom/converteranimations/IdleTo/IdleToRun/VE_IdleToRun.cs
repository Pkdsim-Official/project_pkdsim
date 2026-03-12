using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.IdleTo.IdleToRun
{
	public class GARCParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator GarchompParentMom_Animator;
		public void GARCParentMom_IdleToRunController()
		{
			GarchompParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GarchompParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}
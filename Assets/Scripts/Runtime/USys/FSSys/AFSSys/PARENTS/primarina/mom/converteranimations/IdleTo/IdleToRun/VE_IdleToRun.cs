using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.converteranimations.IdleTo.IdleToRun
{
	public class PRParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator PrimarinaParentMom_Animator;
		public void PRParentMom_IdleToRunController()
		{
			PrimarinaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			PrimarinaParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}
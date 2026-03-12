using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations.IdleTo.IdleToRun
{
	public class FRParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator FrostlassParentMom_Animator;
		public void FRParentMom_IdleToRunController()
		{
			FrostlassParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FrostlassParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}
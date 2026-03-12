using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class ABParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator AbsolParentMom_Animator;
		public void ABParentMom_IdleToWalkController()
		{
			AbsolParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			AbsolParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}
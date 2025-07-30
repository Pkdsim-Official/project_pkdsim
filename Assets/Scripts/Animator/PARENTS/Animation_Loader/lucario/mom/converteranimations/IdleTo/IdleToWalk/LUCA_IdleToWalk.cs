using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lucario.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class LUCAParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator LucarioParentMom_Animator;
		public void LUCAParentMom_IdleToWalkController()
		{
			LucarioParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LucarioParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}
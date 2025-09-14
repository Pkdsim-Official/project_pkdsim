using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class TParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator TsareenaParentMom_Animator;
		public void TParentMom_IdleToWalkController()
		{
			TsareenaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			TsareenaParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}
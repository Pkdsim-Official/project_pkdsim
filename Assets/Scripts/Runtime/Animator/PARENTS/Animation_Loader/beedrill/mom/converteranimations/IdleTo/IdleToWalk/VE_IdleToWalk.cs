using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Beedrill.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class BEParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator BeedrillParentMom_Animator;
		public void BEParentMom_IdleToWalkController()
		{
			BeedrillParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BeedrillParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}
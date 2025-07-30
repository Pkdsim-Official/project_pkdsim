using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class VEParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator VespiquenParentMom_Animator;
		public void VEParentMom_IdleToWalkController()
		{
			VespiquenParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			VespiquenParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}
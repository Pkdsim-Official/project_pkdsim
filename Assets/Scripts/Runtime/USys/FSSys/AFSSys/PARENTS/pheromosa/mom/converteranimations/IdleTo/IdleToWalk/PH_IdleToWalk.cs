using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.converteranimations.IdleTo.IdleToWalk
{
	public class PHParentMom_IdleToWalk : MonoBehaviour 
	{
		private Animator PheromosaParentMom_Animator;
		public void PHParentMom_IdleToWalkController()
		{
			PheromosaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			PheromosaParentMom_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}
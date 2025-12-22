using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.IdleTo.IdleToWalk
{
	public class VEParentDad_IdleToWalk : MonoBehaviour 
	{
		private Animator VespiquenParentDad_Animator;
		public void VEParentDad_IdleToWalkController()
		{
			VespiquenParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			VespiquenParentDad_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}
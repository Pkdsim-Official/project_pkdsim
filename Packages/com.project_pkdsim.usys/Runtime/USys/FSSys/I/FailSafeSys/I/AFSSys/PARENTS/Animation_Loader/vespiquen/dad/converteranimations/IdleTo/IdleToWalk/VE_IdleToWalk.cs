using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.IdleTo.IdleToWalk
{
	public class VEParentDad_IdleToWalk : MonoBehaviour 
	{
		private Animator Vespiquen_Animator;
		public void VEParentDad_IdleToWalkController()
		{
			Vespiquen_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vespiquen_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}
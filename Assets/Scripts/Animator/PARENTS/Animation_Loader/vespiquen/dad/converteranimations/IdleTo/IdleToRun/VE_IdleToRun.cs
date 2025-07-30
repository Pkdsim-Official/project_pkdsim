using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.IdleTo.IdleToRun
{
	public class VEParentDad_IdleToRun : MonoBehaviour 
	{
		private Animator VespiquenParentDad_Animator;
		public void VEParentDad_IdleToRunController()
		{
			VespiquenParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			VespiquenParentDad_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}
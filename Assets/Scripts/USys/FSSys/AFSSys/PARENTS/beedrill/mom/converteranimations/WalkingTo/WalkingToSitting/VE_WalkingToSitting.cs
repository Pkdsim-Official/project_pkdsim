using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class BEParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator BeedrillParentMom_Animator;
		public void BEParentMom_WalkingToSittingController()
		{
			BeedrillParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BeedrillParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}
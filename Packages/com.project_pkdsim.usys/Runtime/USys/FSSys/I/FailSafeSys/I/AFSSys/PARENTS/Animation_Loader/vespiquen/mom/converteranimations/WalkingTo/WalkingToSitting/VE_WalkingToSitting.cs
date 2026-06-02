using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class VEParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator Vespiquen_Animator;
		public void VEParentMom_WalkingToSittingController()
		{
			Vespiquen_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vespiquen_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}
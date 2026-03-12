using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.WalkingTo.WalkingToSitting
{
	public class VEParentDad_WalkingToSitting : MonoBehaviour 
	{
		private Animator VespiquenParentDad_Animator;
		public void VEParentDad_WalkingToSittingController()
		{
			VespiquenParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			VespiquenParentDad_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class GLParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator GlaceonParentMom_Animator;
		public void GLParentMom_WalkingToSittingController()
		{
			GlaceonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GlaceonParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}
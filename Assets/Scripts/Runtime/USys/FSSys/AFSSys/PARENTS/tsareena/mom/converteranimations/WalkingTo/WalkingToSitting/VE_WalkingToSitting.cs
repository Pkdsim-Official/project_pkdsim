using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.converteranimations.WalkingTo.WalkingToSitting
{
	public class TParentMom_WalkingToSitting : MonoBehaviour 
	{
		private Animator TsareenaParentMom_Animator;
		public void TParentMom_WalkingToSittingController()
		{
			TsareenaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			TsareenaParentMom_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.idlebaseanimation.IdleSitting
{
	public class VEParentDad_IdleSitting : MonoBehaviour 
	{
		private Animator VespiquenParentDad_Animator;
		public void VEParentDad_IdleSittingController()
		{
			VespiquenParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			VespiquenParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
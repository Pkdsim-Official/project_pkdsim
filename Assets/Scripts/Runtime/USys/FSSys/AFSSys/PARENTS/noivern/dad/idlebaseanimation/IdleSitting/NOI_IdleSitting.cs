using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.idlebaseanimation.IdleSitting
{
	public class NOIParentDad_IdleSitting : MonoBehaviour 
	{
		private Animator NoivernParentDad_Animator;
		public void NOIParentDad_IdleSittingController()
		{
			NoivernParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			NoivernParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
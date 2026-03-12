using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.idlebaseanimation.IdleSitting
{
	public class ES_IdleSitting : MonoBehaviour 
	{
		public Animator EspeonParentDad_Animator;
		public void ES_IdleSittingController()
		{
			EspeonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			EspeonParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
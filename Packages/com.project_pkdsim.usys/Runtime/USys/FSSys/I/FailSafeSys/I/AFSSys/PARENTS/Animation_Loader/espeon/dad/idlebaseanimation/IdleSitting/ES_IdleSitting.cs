using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Dad.idlebaseanimation.IdleSitting
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
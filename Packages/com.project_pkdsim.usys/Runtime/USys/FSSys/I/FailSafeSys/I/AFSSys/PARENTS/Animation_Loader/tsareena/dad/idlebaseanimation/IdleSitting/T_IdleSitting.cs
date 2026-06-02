using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Dad.idlebaseanimation.IdleSitting
{
	public class TParentDad_IdleSitting : MonoBehaviour 
	{
		private Animator TsareenaParentDad_Animator;
		public void TParentDad_IdleSittingController()
		{
			TsareenaParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			TsareenaParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
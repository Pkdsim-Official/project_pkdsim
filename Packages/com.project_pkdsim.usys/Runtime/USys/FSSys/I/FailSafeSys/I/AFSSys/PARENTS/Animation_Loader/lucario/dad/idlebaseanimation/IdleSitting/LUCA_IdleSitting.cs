using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.idlebaseanimation.IdleSitting
{
	public class LUCAParentDad_IdleSitting : MonoBehaviour 
	{
		private Animator Lucario_Animator;
		public void LUCAParentDad_IdleSittingController()
		{
			Lucario_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Lucario_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Dad.idlebaseanimation.IdleSitting
{
	public class GARDIdleSitting : MonoBehaviour 
	{
		private Animator GardevoirParentDad_Animator;
		public void GARDIdleSittingController()
		{
			GardevoirParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GardevoirParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
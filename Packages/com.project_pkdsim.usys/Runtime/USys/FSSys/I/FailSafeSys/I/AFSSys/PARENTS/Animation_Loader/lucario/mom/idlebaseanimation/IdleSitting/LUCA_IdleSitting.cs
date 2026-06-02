using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.idlebaseanimation.IdleSitting
{
	public class LUCAParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator Lucario_Animator;
		public void LUCAParentMom_IdleSittingController()
		{
			Lucario_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Lucario_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.idlebaseanimation.IdleSitting
{
	public class LUCAParentDad_IdleSitting : MonoBehaviour 
	{
		private Animator LucarioParentDad_Animator;
		public void LUCAParentDad_IdleSittingController()
		{
			LucarioParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LucarioParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
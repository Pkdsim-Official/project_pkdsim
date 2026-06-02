using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.idlebaseanimation.IdleStanding
{
	public class T_IdleStanding : MonoBehaviour 
	{
		public Animator TsareenaParentMom_Animator;
		public void T_IdleStandingController()
		{
			// Assign the idle animation clip
			TsareenaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			TsareenaParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}
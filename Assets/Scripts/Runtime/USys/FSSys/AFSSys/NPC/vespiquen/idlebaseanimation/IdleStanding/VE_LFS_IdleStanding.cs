using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.idlebaseanimation.IdleStanding
{
	public class VE_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Vespiquen_Animator;
		public void VE_LFS_IdleStandingController()
		{
			// Assign the idle animation clip
			Vespiquen_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vespiquen_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}
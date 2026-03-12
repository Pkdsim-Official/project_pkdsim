using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Player.idlebaseanimation.IdleStanding
{
	public class Player_IdleStanding : MonoBehaviour 
	{
		public Animator Player_Animator;
		public void Player_IdleStandingController()
		{
			// Assign the idle animation clip
			Player_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Player_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}
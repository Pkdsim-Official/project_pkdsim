using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.Player.idlebaseanimation.IdleSitting
{
	public class Player_IdleSitting : MonoBehaviour 
	{
		private Animator Player_Animator;
		public void Player_IdleSittingController()
		{
			Player_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Player_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}
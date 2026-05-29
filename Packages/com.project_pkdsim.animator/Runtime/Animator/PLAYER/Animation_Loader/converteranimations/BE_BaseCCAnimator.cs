using project_pkdsim.ANIMATOR.Player.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Player.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Player.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Player.converteranimations
{
	public class Player_ConverterToAnimatorController : MonoBehaviour 
	{
		private Player_SittingTo Player_Sittingto;
		
		private Player_WalkingTo Player_Walkingto;
		
		private Player_IdleTo PlayerIdleto;

		public void PL_ConverterToAnimatorController()
		{
			Player_Walkingto.Player_WalkingToController();

			PlayerIdleto.Player_IdleToController();
			
			Player_Sittingto.Player_SittingToController();	
		}
	}
}
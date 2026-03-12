using Project_Pkdsim.ANIMATOR.Npcs.Lucario.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Npcs.Lucario.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Lucario.converteranimations.SittingTo
{
	public class LUCA_SittingTo : MonoBehaviour 
	{
		private LUCA_SittingToStartWalking LucariosittingToStartWalking;
		private LUCA_SittingToStanding LucariosittingToStanding;
		public void LUCA_SittingToController()
		{
			LUCA_SittingToStartWalking();
			LUCA_SittingToStanding();
		}
		private void LUCA_SittingToStartWalking()
		{
			LucariosittingToStartWalking.LUCA_SittingToStartWalkingController();
		}
		private void LUCA_SittingToStanding()
		{
			LucariosittingToStanding.LUCA_SittingToStandingController();
		}
	}
}
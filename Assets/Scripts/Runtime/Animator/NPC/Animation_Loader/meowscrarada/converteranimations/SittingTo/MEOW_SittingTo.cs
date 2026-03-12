using Project_Pkdsim.ANIMATOR.Npcs.Meowscarada.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Npcs.Meowscarada.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Meowscarada.converteranimations.SittingTo
{
	public class MEOW_SittingTo : MonoBehaviour 
	{
		private MEOW_SittingToStartWalking MeowscaradasittingToStartWalking;
		private MEOW_SittingToStanding MeowscaradasittingToStanding;
		public void MEOW_SittingToController()
		{
			MEOW_SittingToStartWalking();
			MEOW_SittingToStanding();
		}
		private void MEOW_SittingToStartWalking()
		{
			MeowscaradasittingToStartWalking.MEOW_SittingToStartWalkingController();
		}
		private void MEOW_SittingToStanding()
		{
			MeowscaradasittingToStanding.MEOW_SittingToStandingController();
		}

	}
}
using project_pkdsim.ANIMATOR.NPC.Meowscarada.converteranimations._SittingTo._SittingToStartWalking;
using project_pkdsim.ANIMATOR.NPC.Meowscarada.converteranimations._SittingTo._SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Meowscarada.converteranimations._SittingTo
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
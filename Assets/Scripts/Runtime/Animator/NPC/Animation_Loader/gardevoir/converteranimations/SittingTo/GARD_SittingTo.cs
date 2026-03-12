using Project_Pkdsim.ANIMATOR.Npcs.Gardevoir.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Npcs.Gardevoir.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Gardevoir.converteranimations.SittingTo
{
	public class GARD_SittingTo : MonoBehaviour 
	{
		private GARD_SittingToStartWalking Gardevoir_SittingToStartWalking;
		private GARD_SittingToStanding Gardevoir_SittingToStanding;
		public void GARD_SittingToController()
		{
			GARD_SittingToStartWalking();
			GARD_SittingToStanding();
		}
		private void GARD_SittingToStartWalking()
		{
			Gardevoir_SittingToStartWalking.GARD_SittingToStartWalkingController();
		}
		private void GARD_SittingToStanding()
		{
			Gardevoir_SittingToStanding.GARD_SittingToStandingController();
		}
	}
}
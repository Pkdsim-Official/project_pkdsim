using Project_Pkdsim.ANIMATOR.Npcs.Gardevoir.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Gardevoir.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Gardevoir.converteranimations.WalkingTo
{
	public class GARD_WalkingTo : MonoBehaviour 
	{
		private GARD_WalkingToSitting Gardevoir_WalkingToSitting;
		private GARD_WalkingToStanding Gardevoir_WalkingToStanding;
		public void GARD_WalkingToController()
		{
			GARD_WalkingToStartWalking();
			GARD_WalkingToStanding();
		}
		private void GARD_WalkingToStartWalking()
		{
			Gardevoir_WalkingToSitting.GARD_WalkingToSittingController();
		}
		private void GARD_WalkingToStanding()
		{
			Gardevoir_WalkingToStanding.GARD_WalkingToStandingController();
		}
	}
}
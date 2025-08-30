using project_pkdsim.Models.ANIMATOR.NPC.Gardevoir.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Models.ANIMATOR.NPC.Gardevoir.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Gardevoir.converteranimations.WalkingTo
{
	public class GARDWalkingTo : MonoBehaviour 
	{
		private GARDWalkingToSitting GardevoirWalkingToSitting;
		private GARDWalkingToStanding GardevoirWalkingToStanding;
		public void GARDWalkingToController()
		{
			GARDWalkingToStartWalking();
			GARDWalkingToStanding();
		}
		private void GARDWalkingToStartWalking()
		{
			GardevoirWalkingToSitting.GARDWalkingToSittingController();
		}
		private void GARDWalkingToStanding()
		{
			GardevoirWalkingToStanding.GARDWalkingToStandingController();
		}
	}
}
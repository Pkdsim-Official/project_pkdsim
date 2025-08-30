using project_pkdsim.Models.ANIMATOR.NPC.Absol.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Models.ANIMATOR.NPC.Absol.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Absol.converteranimations.WalkingTo
{
	public class ABWalkingTo : MonoBehaviour 
	{
		private ABWalkingToSitting AbsolWalkingToSitting;
		private ABWalkingToStanding AbsolWalkingToStanding;
		public void ABWalkingToController()
		{
			ABWalkingToStartWalking();
			ABWalkingToStanding();
		}
		private void ABWalkingToStartWalking()
		{
			AbsolWalkingToSitting.ABWalkingToSittingController();
		}
		private void ABWalkingToStanding()
		{
			AbsolWalkingToStanding.ABWalkingToStandingController();
		}
	}
}
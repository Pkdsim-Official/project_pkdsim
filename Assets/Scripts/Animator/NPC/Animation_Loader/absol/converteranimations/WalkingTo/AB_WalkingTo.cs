using project_pkdsim.Models.ANIMATOR.NPC.Absol.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Models.ANIMATOR.NPC.Absol.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Absol.converteranimations.WalkingTo
{
	public class AB_WalkingTo : MonoBehaviour 
	{
		private AB_WalkingToSitting AbsolWalkingToSitting;
		private AB_WalkingToStanding AbsolWalkingToStanding;
		public void AB_WalkingToController()
		{
			AB_WalkingToStartWalking();
			AB_WalkingToStanding();
		}
		private void AB_WalkingToStartWalking()
		{
			AbsolWalkingToSitting.AB_WalkingToSittingController();
		}
		private void AB_WalkingToStanding()
		{
			AbsolWalkingToStanding.AB_WalkingToStandingController();
		}
	}
}
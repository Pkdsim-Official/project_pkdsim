using project_pkdsim.Models.ANIMATOR.NPC.Braixen.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Models.ANIMATOR.NPC.Braixen.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Braixen.converteranimations.WalkingTo
{
	public class BRWalkingTo : MonoBehaviour 
	{
		private BRWalkingToStanding BraixenWalkingToStanding;
		private BRWalkingToSitting BraixenWalkingToSitting;
		public void BRWalkingToController()
		{
			Load_BRWalkingToStanding();
			Load_BRWalkingToWSitting();
		}
		private void Load_BRWalkingToStanding()
		{
			BraixenWalkingToStanding.BRWalkingToStandingController();
		}
		private void Load_BRWalkingToWSitting()
		{
			BraixenWalkingToSitting.BRWalkingToSittingController();
		}
	}
}
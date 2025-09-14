using project_pkdsim.ANIMATOR.Npcs.Dragapult.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Npcs.Dragapult.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Dragapult.converteranimations.WalkingTo
{
	public class DR_WalkingTo : MonoBehaviour 
	{
		private DR_WalkingToSitting Dragapult_WalkingToSitting;
		private DR_WalkingToStanding Dragapult_WalkingToStanding;
		public void DR_WalkingToController()
		{
			DR_WalkingToStartWalking();
			DR_WalkingToStanding();
		}
		private void DR_WalkingToStartWalking()
		{
			Dragapult_WalkingToSitting.DR_WalkingToSittingController();
		}
		private void DR_WalkingToStanding()
		{
			Dragapult_WalkingToStanding.DR_WalkingToStandingController();
		}
	}
}

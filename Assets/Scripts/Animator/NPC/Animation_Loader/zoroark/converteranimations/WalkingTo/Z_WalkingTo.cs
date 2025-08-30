using project_pkdsim.Models.ANIMATOR.NPC.Zoroark.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Models.ANIMATOR.NPC.Zoroark.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Zoroark.converteranimations.WalkingTo
{
	public class ZWalkingTo : MonoBehaviour 
	{
		private ZWalkingToStanding ZoroarkWalkingToStanding;
		private ZWalkingToSitting ZoroarkWalkingToSitting;
		
		public void ZWalkingToController() 
		{
			Load_ZWalkingToStandingController();
			Load_ZWalkingToSittingController();
		}

		private void Load_ZWalkingToStandingController()
		{
			ZoroarkWalkingToStanding.ZWalkingToStandingController();
		}
		
		private void Load_ZWalkingToSittingController()
		{
			ZoroarkWalkingToSitting.ZWalkingToSittingController();
		}
	}
}
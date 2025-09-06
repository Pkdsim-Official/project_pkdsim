using project_pkdsim.ANIMATOR.NPC.Lopunny.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.NPC.Lopunny.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Lopunny.converteranimations.WalkingTo
{
	public class LOWalkingTo : MonoBehaviour 
	{
		private LOWalkingToStanding LopunnyWalkingToStanding;
		private LOWalkingToSitting LopunnyWalkingToSitting;
		public void LOWalkingToController()
		{
			Load_LOWalkingToStanding();
			Load_LOWalkingToWSitting();
		}
		private void Load_LOWalkingToStanding()
		{
			LopunnyWalkingToStanding.LOWalkingToStandingController();
		}
		private void Load_LOWalkingToWSitting()
		{
			LopunnyWalkingToSitting.LOWalkingToSittingController();
		}
	}
}
using project_pkdsim.ANIMATOR.NPC.Hatterene.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.NPC.Hatterene.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Hatterene.converteranimations.WalkingTo
{
	public class HATWalkingTo : MonoBehaviour 
	{
		private HATWalkingToStanding HattereneWalkingToStanding;
		private HATWalkingToSitting HattereneWalkingToSitting;
		public void HATWalkingToController()
		{
			Load_HATWalkingToStanding();
			Load_HATWalkingToWSitting();
		}
		private void Load_HATWalkingToStanding()
		{
			HattereneWalkingToStanding.HATWalkingToStandingController();
		}
		private void Load_HATWalkingToWSitting()
		{
			HattereneWalkingToSitting.HATWalkingToSittingController();
		}
	}
}
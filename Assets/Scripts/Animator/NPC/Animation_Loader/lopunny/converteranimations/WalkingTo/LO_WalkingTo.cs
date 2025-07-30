using project_pkdsim.ANIMATOR.Npcs.Lopunny.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Npcs.Lopunny.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Lopunny.converteranimations.WalkingTo
{
	public class LO_WalkingTo : MonoBehaviour 
	{
		private LO_WalkingToStanding Lopunny_WalkingToStanding;
		private LO_WalkingToSitting Lopunny_WalkingToSitting;
		public void LO_WalkingToController()
		{
			Load_LO_WalkingToStanding();
			Load_LO_WalkingToWSitting();
		}
		private void Load_LO_WalkingToStanding()
		{
			Lopunny_WalkingToStanding.LO_WalkingToStandingController();
		}
		private void Load_LO_WalkingToWSitting()
		{
			Lopunny_WalkingToSitting.LO_WalkingToSittingController();
		}
	}
}
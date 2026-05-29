using project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations.WalkingTo
{
	public class FR_WalkingTo : MonoBehaviour 
	{
		
		private FR_WalkingToStanding FrostlassWalkingToStanding;
		private FR_WalkingToSitting FrostlassWalkingToSitting;
		public void FR_WalkingToController()
		{
			Load_FR_WalkingToStanding();
			Load_FR_WalkingToWSitting();
		}
		private void Load_FR_WalkingToStanding()
		{
			FrostlassWalkingToStanding.FR_WalkingToStandingController();
		}
		private void Load_FR_WalkingToWSitting()
		{
			FrostlassWalkingToSitting.FR_WalkingToSittingController();
		}
	}
}
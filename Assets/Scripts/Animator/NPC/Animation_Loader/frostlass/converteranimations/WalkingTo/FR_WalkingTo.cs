using project_pkdsim.Models.ANIMATOR.NPC.Frostlass.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Models.ANIMATOR.NPC.Frostlass.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Frostlass.converteranimations.WalkingTo
{
	public class FRWalkingTo : MonoBehaviour 
	{
		
		private FRWalkingToStanding FrostlassWalkingToStanding;
		private FRWalkingToSitting FrostlassWalkingToSitting;
		public void FRWalkingToController()
		{
			Load_FRWalkingToStanding();
			Load_FRWalkingToWSitting();
		}
		private void Load_FRWalkingToStanding()
		{
			FrostlassWalkingToStanding.FRWalkingToStandingController();
		}
		private void Load_FRWalkingToWSitting()
		{
			FrostlassWalkingToSitting.FRWalkingToSittingController();
		}
	}
}
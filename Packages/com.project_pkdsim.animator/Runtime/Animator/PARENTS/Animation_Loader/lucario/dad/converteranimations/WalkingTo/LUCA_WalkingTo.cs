using project_pkdsim.ANIMATOR.Parents.Lucario.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Lucario.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lucario.Dad.converteranimations.WalkingTo
{
	public class LUCAWalkingTo : MonoBehaviour 
	{
		private LUCAWalkingToStanding LucarioWalkingToStanding;
		private LUCAWalkingToSitting LucarioWalkingToSitting;
		public void LUCAWalkingToController()
		{
			Load_LUCAWalkingToStanding();
			Load_LUCAWalkingToWSitting();
		}
		private void Load_LUCAWalkingToStanding()
		{
			LucarioWalkingToStanding.LUCAWalkingToStandingController();
		}
		private void Load_LUCAWalkingToWSitting()
		{
			LucarioWalkingToSitting.LUCAWalkingToSittingController();
		}
	}
}
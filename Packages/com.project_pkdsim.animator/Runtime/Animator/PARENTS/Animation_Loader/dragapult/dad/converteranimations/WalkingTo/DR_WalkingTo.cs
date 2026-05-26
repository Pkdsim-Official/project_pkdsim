using project_pkdsim.ANIMATOR.Parents.Dragapult.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Dragapult.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Dragapult.converteranimations.WalkingTo
{
	public class DRWalkingTo : MonoBehaviour 
	{
		private DRWalkingToSitting DragapultWalkingToSitting;
		private DRWalkingToStanding DragapultWalkingToStanding;
		public void DRWalkingToController()
		{
			DRWalkingToStartWalking();
			DRWalkingToStanding();
		}
		private void DRWalkingToStartWalking()
		{
			DragapultWalkingToSitting.DRWalkingToSittingController();
		}
		private void DRWalkingToStanding()
		{
			DragapultWalkingToStanding.DRWalkingToStandingController();
		}
	}
}

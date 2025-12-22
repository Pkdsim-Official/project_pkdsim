using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Dad.converteranimations.WalkingTo
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

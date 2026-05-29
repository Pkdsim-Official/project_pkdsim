using project_pkdsim.ANIMATOR.Parents.Dragapult.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Dragapult.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Dragapult.Mom.converteranimations.SittingTo
{
	public class DRSittingTo : MonoBehaviour 
	{
		private DRSittingToStartWalking DragapultsittingToStartWalking;
		private DRSittingToStanding DragapultsittingToStanding;
		public void DRSittingToController()
		{
			DRSittingToStartWalking();
			DRSittingToStanding();
		}
		private void DRSittingToStartWalking()
		{
			DragapultsittingToStartWalking.DRSittingToStartWalkingController();
		}
		private void DRSittingToStanding()
		{
			DragapultsittingToStanding.DRSittingToStandingController();
		}
	}
}
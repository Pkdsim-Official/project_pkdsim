using Project_Pkdsim.ANIMATOR.Parents.Delphox.Dad.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Parents.Delphox.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Delphox.Dad.converteranimations.SittingTo
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
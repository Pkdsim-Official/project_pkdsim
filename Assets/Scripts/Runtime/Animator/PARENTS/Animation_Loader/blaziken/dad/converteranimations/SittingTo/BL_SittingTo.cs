using Project_Pkdsim.ANIMATOR.Parents.Blaziken.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Parents.Blaziken.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Blaziken.converteranimations.SittingTo
{
	public class BL_SittingTo : MonoBehaviour 
	{
		private BL_SittingToStartWalking BlazikenSittingToStartWalking;
		private BL_SittingToStanding BlazikenSittingToStanding;
		public void BL_SittingToController()
		{
			BL_SittingToStartWalking();
			BL_SittingToStanding();
		}
		private void BL_SittingToStartWalking()
		{
			BlazikenSittingToStartWalking.BL_SittingToStartWalkingController();
		}
		private void BL_SittingToStanding()
		{
			BlazikenSittingToStanding.BL_SittingToStandingController();
		}

	}
}
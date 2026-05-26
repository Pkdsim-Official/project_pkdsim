using project_pkdsim.ANIMATOR.Parents.Delphox.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Delphox.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Delphox.converteranimations.SittingTo
{
	public class DLSittingTo : MonoBehaviour 
	{
		private DLSittingToStartWalking DelphoxsittingToStartWalking;
		private DLSittingToStanding DelphoxsittingToStanding;
		public void DLSittingToController()
		{
			DLSittingToStartWalking();
			DLSittingToStanding();
		}
		private void DLSittingToStartWalking()
		{
			DelphoxsittingToStartWalking.DLSittingToStartWalkingController();
		}
		private void DLSittingToStanding()
		{
			DelphoxsittingToStanding.DLSittingToStandingController();
		}

	}
}
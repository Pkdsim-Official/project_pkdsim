using project_pkdsim.ANIMATOR.Parents.Delphox.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Delphox.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Delphox.Mom.converteranimations.SittingTo
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
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Dad.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Dad.converteranimations.SittingTo
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
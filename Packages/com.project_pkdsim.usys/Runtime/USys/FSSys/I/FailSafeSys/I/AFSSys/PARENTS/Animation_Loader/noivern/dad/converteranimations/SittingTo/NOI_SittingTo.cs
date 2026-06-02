using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.converteranimations.SittingTo
{
	public class NOISittingTo : MonoBehaviour 
	{
		private NOISittingToStartWalking NoivernsittingToStartWalking;
		private NOISittingToStanding NoivernsittingToStanding;
		public void NOISittingToController()
		{
			NOISittingToStartWalking();
			NOISittingToStanding();
		}
		private void NOISittingToStartWalking()
		{
			NoivernsittingToStartWalking.NOISittingToStartWalkingController();
		}
		private void NOISittingToStanding()
		{
			NoivernsittingToStanding.NOISittingToStandingController();
		}
	}
}
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.converteranimations.SittingTo
{
	public class ABParentMom_SittingTo : MonoBehaviour 
	{
		private ABParentMom_SittingToStartWalking AbsolSittingToStartWalking;
		private ABParentMom_SittingToStanding AbsolSittingToStanding;
		public void ABParentMom_SittingToController()
		{
			ABParentMom_SittingToStartWalking();
			ABParentMom_SittingToStanding();
		}
		public void ABParentMom_SittingToStartWalking()
		{
			AbsolSittingToStartWalking.ABParentMom_SittingToStartWalkingController();
		}
		public void ABParentMom_SittingToStanding()
		{
			AbsolSittingToStanding.ABParentMom_SittingToStandingController();
		}

	}
}
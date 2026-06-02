using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.converteranimations.SittingTo
{
	public class LOParentDad_SittingTo : MonoBehaviour 
	{
		private LOParentDad_SittingToStartWalking LopunnysittingToStartWalking;
		private LOParentDad_SittingToStanding LopunnysittingToStanding;
		public void LOParentDad_SittingToController()
		{
			LOParentDad_SittingToStartWalking();
			LOParentDad_SittingToStanding();
		}
		private void LOParentDad_SittingToStartWalking()
		{
			LopunnysittingToStartWalking.LOParentDad_SittingToStartWalkingController();
		}
		private void LOParentDad_SittingToStanding()
		{
			LopunnysittingToStanding.LOParentDad_SittingToStandingController();
		}

	}
}
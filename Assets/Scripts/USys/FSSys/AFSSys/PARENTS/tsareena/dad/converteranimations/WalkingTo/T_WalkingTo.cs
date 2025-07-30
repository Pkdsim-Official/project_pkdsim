using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Dad.converteranimations.WalkingTo.WalkingToStanding;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Dad.converteranimations.WalkingTo.WalkingToSitting;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Dad.converteranimations.WalkingTo
{
	public class TParentDad_WalkingTo : MonoBehaviour 
	{
		private TParentDad_WalkingToSitting TsareenaWalkingToSitting;
		private TParentDad_WalkingToStanding TsareenaWalkingToStanding;
		public void TParentDad_WalkingToController()
		{
			TParentDad_WalkingToSitting();
			TParentDad_WalkingToStanding();
		}
		private void TParentDad_WalkingToSitting()
		{
			TsareenaWalkingToSitting.TParentDad_WalkingToSittingController();
		}
		private void TParentDad_WalkingToStanding()
		{
			TsareenaWalkingToStanding.TParentDad_WalkingToStandingController();
		}
	}
}
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Dad.converteranimations.WalkingTo
{
	public class ZParentDad_WalkingTo : MonoBehaviour 
	{
		private ZParentDad_WalkingToStanding ZoroarkParentDad_WalkingToStanding;
		private ZParentDad_WalkingToSitting ZoroarkParentDad_WalkingToSitting;
		
		public void ZParentDad_WalkingToController() 
		{
			Load_ZParentDad_WalkingToStandingController();
			Load_ZParentDad_WalkingToSittingController();
		}

		private void Load_ZParentDad_WalkingToStandingController()
		{
			ZoroarkParentDad_WalkingToStanding.ZParentDad_WalkingToStandingController();
		}
		
		private void Load_ZParentDad_WalkingToSittingController()
		{
			ZoroarkParentDad_WalkingToSitting.ZParentDad_WalkingToSittingController();
		}
	}
}
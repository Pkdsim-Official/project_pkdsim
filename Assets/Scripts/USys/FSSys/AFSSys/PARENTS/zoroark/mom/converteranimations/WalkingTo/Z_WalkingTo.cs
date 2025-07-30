using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.converteranimations.WalkingTo
{
	public class ZParentMom_WalkingTo : MonoBehaviour 
	{
		private ZParentMom_WalkingToStanding ZoroarkWalkingToStanding;
		private ZParentMom_WalkingToSitting ZoroarkWalkingToSitting;
		
		public void ZParentMom_WalkingToController() 
		{
			Load_ZParentMom_WalkingToStandingController();
			Load_ZParentMom_WalkingToSittingController();
		}

		private void Load_ZParentMom_WalkingToStandingController()
		{
			ZoroarkWalkingToStanding.ZParentMom_WalkingToStandingController();
		}
		
		private void Load_ZParentMom_WalkingToSittingController()
		{
			ZoroarkWalkingToSitting.ZParentMom_WalkingToSittingController();
		}
	}
}
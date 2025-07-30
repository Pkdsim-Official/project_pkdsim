using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Braixen.Dad.converteranimations.WalkingTo
{
	public class BRParentDad_WalkingTo : MonoBehaviour 
	{
		private BRParentDad_WalkingToStanding BraixenWalkingToStanding;
		private BRParentDad_WalkingToSitting BraixenWalkingToSitting;
		public void BRParentDad_WalkingToController()
		{
			Load_BRParentDad_WalkingToStanding();
			Load_BRParentDad_WalkingToWSitting();
		}
		private void Load_BRParentDad_WalkingToStanding()
		{
			BraixenWalkingToStanding.BRParentDad_WalkingToStandingController();
		}
		private void Load_BRParentDad_WalkingToWSitting()
		{
			BraixenWalkingToSitting.BRParentDad_WalkingToSittingController();
		}
	}
}
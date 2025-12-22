using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.converteranimations.WalkingTo
{
	public class LUCAParentDad_WalkingTo : MonoBehaviour 
	{
		private LUCAParentDad_WalkingToStanding LucarioWalkingToStanding;
		private LUCAParentDad_WalkingToSitting LucarioWalkingToSitting;
		public void LUCAParentDad_WalkingToController()
		{
			Load_LUCAParentDad_WalkingToStanding();
			Load_LUCAParentDad_WalkingToWSitting();
		}
		private void Load_LUCAParentDad_WalkingToStanding()
		{
			LucarioWalkingToStanding.LUCAParentDad_WalkingToStandingController();
		}
		private void Load_LUCAParentDad_WalkingToWSitting()
		{
			LucarioWalkingToSitting.LUCAParentDad_WalkingToSittingController();
		}
	}
}
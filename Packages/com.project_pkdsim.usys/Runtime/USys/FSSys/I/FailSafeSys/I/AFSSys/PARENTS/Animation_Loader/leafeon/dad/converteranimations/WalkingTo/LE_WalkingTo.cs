using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.converteranimations.WalkingTo
{
	public class LEParentDad_WalkingTo : MonoBehaviour 
	{
		private LEParentDad_WalkingToStanding LeafeonParentDad_walkingtostanding;
		private LEParentDad_WalkingToSitting LeafeonParentDad_walkingtositting;
		public void LEParentDad_WalkingToController() {
			LEParentDad_WalkingToStartWalkingController();
			LEParentDad_WalkingToStandingController();
		}
		public void LEParentDad_WalkingToStartWalkingController() {
			LeafeonParentDad_walkingtositting.LEParentDad_WalkingToSittingController();
		}
		public void LEParentDad_WalkingToStandingController() {
			LeafeonParentDad_walkingtostanding.LEParentDad_WalkingToStandingController();
		}
	}
}
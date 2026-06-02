using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.converteranimations.WalkingTo
{
	public class ES_WalkingTo : MonoBehaviour 
	{
		private ES_WalkingToSitting ES_WalkingToSitting;
		private ES_WalkingToStanding ES_WalkingToStanding;
		public void ES_WalkingToController()
		{
			ES_WalkingToSitting.ES_WalkingToSittingController();
			ES_WalkingToStanding.ES_WalkingToStandingController();
		}
	}
}
using project_pkdsim.ANIMATOR.Parents.Espeon.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Espeon.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Espeon.Dad.converteranimations.WalkingTo
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
using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.Dad.converteranimations.WalkingTo
{
	public class NOIParentDad_WalkingTo : MonoBehaviour 
	{
		private NOIParentDad_WalkingToSitting NoivernWalkingToSitting;
		private NOIParentDad_WalkingToStanding NoivernWalkingToStanding;
		public void NOIParentDad_WalkingToController()
		{
			NOIParentDad_WalkingToSitting();
			NOIParentDad_WalkingToStanding();
		}
		private void NOIParentDad_WalkingToSitting()
		{
			NoivernWalkingToSitting.NOIParentDad_WalkingToSittingController();
		}
		private void NOIParentDad_WalkingToStanding()
		{
			NoivernWalkingToStanding.NOIParentDad_WalkingToStandingController();
		}
	}
}
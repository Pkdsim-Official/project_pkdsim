using project_pkdsim.ANIMATOR.Parents.Flareon.converteranimations.WalkingTo.WalkingToStanding;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations.WalkingTo.WalkingToSitting;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations.WalkingTo
{
	public class TWalkingTo : MonoBehaviour 
	{
		private TWalkingToSitting TsareenaWalkingToSitting;
		private TWalkingToStanding TsareenaWalkingToStanding;
		public void TWalkingToController()
		{
			TWalkingToSitting();
			TWalkingToStanding();
		}
		private void TWalkingToSitting()
		{
			TsareenaWalkingToSitting.TWalkingToSittingController();
		}
		private void TWalkingToStanding()
		{
			TsareenaWalkingToStanding.TWalkingToStandingController();
		}
	}
}
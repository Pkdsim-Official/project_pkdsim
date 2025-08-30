using project_pkdsim.Models.ANIMATOR.NPC.Flareon.converteranimations.WalkingTo.WalkingToStanding;
using project_pkdsim.Models.ANIMATOR.NPC.Tsareena.converteranimations.WalkingTo.WalkingToSitting;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Tsareena.converteranimations.WalkingTo
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
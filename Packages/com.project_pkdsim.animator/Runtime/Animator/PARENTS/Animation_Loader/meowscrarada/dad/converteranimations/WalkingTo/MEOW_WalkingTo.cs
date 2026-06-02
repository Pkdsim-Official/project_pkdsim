using project_pkdsim.ANIMATOR.Parents.Meowscarada.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Meowscarada.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Meowscarada.converteranimations.WalkingTo
{
	public class MEOW_WalkingTo : MonoBehaviour 
	{
		private MEOW_WalkingToSitting MeowscaradaWalkingToSitting;
		private MEOW_WalkingToStanding MeowscaradaWalkingToStanding;
		public void MEOW_WalkingToController()
		{
			MEOW_WalkingToSitting();
			MEOW_WalkingToStanding();
		}
		private void MEOW_WalkingToSitting()
		{
			MeowscaradaWalkingToSitting.MEOW_WalkingToSittingController();
		}
		private void MEOW_WalkingToStanding()
		{
			MeowscaradaWalkingToStanding.MEOW_WalkingToStandingController();
		}
	}
}
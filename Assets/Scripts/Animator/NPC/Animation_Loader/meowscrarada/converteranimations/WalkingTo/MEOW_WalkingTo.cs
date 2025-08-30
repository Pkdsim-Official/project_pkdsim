using project_pkdsim.Models.ANIMATOR.NPC.Meowscarada.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Models.ANIMATOR.NPC.Meowscarada.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Meowscarada.converteranimations.WalkingTo
{
	public class MEOWWalkingTo : MonoBehaviour 
	{
		private MEOWWalkingToSitting MeowscaradaWalkingToSitting;
		private MEOWWalkingToStanding MeowscaradaWalkingToStanding;
		public void MEOWWalkingToController()
		{
			MEOWWalkingToSitting();
			MEOWWalkingToStanding();
		}
		private void MEOWWalkingToSitting()
		{
			MeowscaradaWalkingToSitting.MEOWWalkingToSittingController();
		}
		private void MEOWWalkingToStanding()
		{
			MeowscaradaWalkingToStanding.MEOWWalkingToStandingController();
		}
	}
}
using project_pkdsim.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.WalkingTo
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
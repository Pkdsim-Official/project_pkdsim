using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.converteranimations.WalkingTo
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
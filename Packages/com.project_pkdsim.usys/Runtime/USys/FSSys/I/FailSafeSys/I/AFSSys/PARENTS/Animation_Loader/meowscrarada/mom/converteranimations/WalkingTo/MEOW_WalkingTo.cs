using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.WalkingTo
{
	public class MEOWParentMom_WalkingTo : MonoBehaviour 
	{
		private MEOWParentMom_WalkingToSitting MeowscaradaWalkingToSitting;
		private MEOWParentMom_WalkingToStanding MeowscaradaWalkingToStanding;
		public void MEOWParentMom_WalkingToController()
		{
			MEOWParentMom_WalkingToSitting();
			MEOWParentMom_WalkingToStanding();
		}
		private void MEOWParentMom_WalkingToSitting()
		{
			MeowscaradaWalkingToSitting.MEOWParentMom_WalkingToSittingController();
		}
		private void MEOWParentMom_WalkingToStanding()
		{
			MeowscaradaWalkingToStanding.MEOWParentMom_WalkingToStandingController();
		}
	}
}
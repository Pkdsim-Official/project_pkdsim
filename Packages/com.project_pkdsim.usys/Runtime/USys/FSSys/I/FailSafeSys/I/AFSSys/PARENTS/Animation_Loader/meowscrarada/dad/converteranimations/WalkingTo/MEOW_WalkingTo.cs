using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.converteranimations.WalkingTo
{
	public class MEOWParentDad_WalkingTo : MonoBehaviour 
	{
		private MEOWParentDad_WalkingToSitting MeowscaradaWalkingToSitting;
		private MEOWParentDad_WalkingToStanding MeowscaradaWalkingToStanding;
		public void MEOWParentDad_WalkingToController()
		{
			MEOWParentDad_WalkingToSitting();
			MEOWParentDad_WalkingToStanding();
		}
		private void MEOWParentDad_WalkingToSitting()
		{
			MeowscaradaWalkingToSitting.MEOWParentDad_WalkingToSittingController();
		}
		private void MEOWParentDad_WalkingToStanding()
		{
			MeowscaradaWalkingToStanding.MEOWParentDad_WalkingToStandingController();
		}
	}
}
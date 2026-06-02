using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.SittingTo
{
	public class MEOWParentMom_SittingTo : MonoBehaviour 
	{
		private MEOWParentMom_SittingToStartWalking MeowscaradasittingToStartWalking;
		private MEOWParentMom_SittingToStanding MeowscaradasittingToStanding;
		public void MEOWParentMom_SittingToController()
		{
			MEOWParentMom_SittingToStartWalking();
			MEOWParentMom_SittingToStanding();
		}
		private void MEOWParentMom_SittingToStartWalking()
		{
			MeowscaradasittingToStartWalking.MEOWParentMom_SittingToStartWalkingController();
		}
		private void MEOWParentMom_SittingToStanding()
		{
			MeowscaradasittingToStanding.MEOWParentMom_SittingToStandingController();
		}

	}
}
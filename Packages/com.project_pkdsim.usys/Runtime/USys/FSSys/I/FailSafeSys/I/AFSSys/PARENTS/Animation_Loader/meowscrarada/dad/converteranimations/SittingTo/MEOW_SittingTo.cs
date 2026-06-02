using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.converteranimations.SittingTo
{
	public class MEOWParentDad_SittingTo : MonoBehaviour 
	{
		private MEOWParentDad_SittingToStartWalking MeowscaradasittingToStartWalking;
		private MEOWParentDad_SittingToStanding MeowscaradasittingToStanding;
		public void MEOWParentDad_SittingToController()
		{
			MEOWParentDad_SittingToStartWalking();
			MEOWParentDad_SittingToStanding();
		}
		private void MEOWParentDad_SittingToStartWalking()
		{
			MeowscaradasittingToStartWalking.MEOWParentDad_SittingToStartWalkingController();
		}
		private void MEOWParentDad_SittingToStanding()
		{
			MeowscaradasittingToStanding.MEOWParentDad_SittingToStandingController();
		}

	}
}
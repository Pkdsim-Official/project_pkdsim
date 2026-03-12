using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.SittingTo
{
	public class MEOWParentMom_SittingTo : MonoBehaviour 
	{
		private MEOWParentMom_SittingToStartWalking MeowscaradaParentMomSittingToStartWalking;
		private MEOWParentMom_SittingToStanding MeowscaradaParentMomSittingToStanding;
		public void MEOWParentMom_SittingToController()
		{
			MEOWParentMom_SittingToStartWalking();
			MEOWParentMom_SittingToStanding();
		}
		private void MEOWParentMom_SittingToStartWalking()
		{
			MeowscaradaParentMomSittingToStartWalking.MEOWParentMom_SittingToStartWalkingController();
		}
		private void MEOWParentMom_SittingToStanding()
		{
			MeowscaradaParentMomSittingToStanding.MEOWParentMom_SittingToStandingController();
		}

	}
}
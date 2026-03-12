using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.converteranimations.SittingTo
{
	public class ESParentMom_SittingTo : MonoBehaviour 
	{
		private ESParentMom_SittingToStartWalking EspeonParentMomSittingToStartWalking;
		private ESParentMom_SittingToStanding EspeonParentMomSittingToStanding;
		public void ESParentMom_SittingToController()
		{
			ESParentMom_SittingToStartWalking();
			ESParentMom_SittingToStanding();
		}
		private void ESParentMom_SittingToStartWalking()
		{
			EspeonParentMomSittingToStartWalking.ESParentMom_SittingToStartWalkingController();
		}
		private void ESParentMom_SittingToStanding()
		{
			EspeonParentMomSittingToStanding.ESParentMom_SittingToStandingController();
		}

	}
}
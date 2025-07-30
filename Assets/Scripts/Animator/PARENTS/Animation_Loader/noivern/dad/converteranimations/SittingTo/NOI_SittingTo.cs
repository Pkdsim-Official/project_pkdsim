using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.Dad.converteranimations.SittingTo
{
	public class NOIParentDad_SittingTo : MonoBehaviour
	{
		private NOIParentDad_SittingToStartWalking NoivernParentDadsittingToStartWalking;
		private NOIParentDad_SittingToStanding NoivernParentDadsittingToStanding;
		public void NOIParentDad_SittingToController()
		{
			NOIParentDad_SittingToStartWalking();
			NOIParentDad_SittingToStanding();
		}
		private void NOIParentDad_SittingToStartWalking()
		{
			NoivernParentDadsittingToStartWalking.NOIParentDad_SittingToStartWalkingController();
		}
		private void NOIParentDad_SittingToStanding()
		{
			NoivernParentDadsittingToStanding.NOIParentDad_SittingToStandingController();
		}
	}
}
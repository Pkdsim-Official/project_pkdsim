using project_pkdsim.ANIMATOR.Parents.Leafeon.Dad.converteranimations.SittingTo.SittingToStanding;
using project_pkdsim.ANIMATOR.Parents.Leafeon.Dad.converteranimations.SittingTo.SittingToStartWalking;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Leafeon.Dad.converteranimations.SittingTo
{
	public class LEParentDad_SittingTo : MonoBehaviour
	{

		private LEParentDad_SittingToStartWalking LeafeonParentDadsittingToStartWalking;
		private LEParentDad_SittingToStanding LeafeonParentDadsittingToStanding;
		public void LEParentDad_SittingToController()
		{
			LEParentDad_SittingToStartWalking();
			LEParentDad_SittingToStanding();
		}
		private void LEParentDad_SittingToStartWalking()
		{
			LeafeonParentDadsittingToStartWalking.LEParentDad_SittingToStartWalkingController();
		}
		private void LEParentDad_SittingToStanding()
		{
			LeafeonParentDadsittingToStanding.LEParentDad_SittingToStandingController();
		}
	}
}
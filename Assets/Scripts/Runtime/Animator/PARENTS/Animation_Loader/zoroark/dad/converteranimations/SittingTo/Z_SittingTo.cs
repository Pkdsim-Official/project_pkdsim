using Project_Pkdsim.ANIMATOR.Parents.Zoroark.Dad.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Parents.Zoroark.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Zoroark.Dad.converteranimations.SittingTo
{
	public class ZParentDad_SittingTo : MonoBehaviour 
	{
		private ZParentDad_SittingToStartWalking ZoroarkParentDadSittingToStartWalking;
		private ZParentDad_SittingToStanding ZoroarkParentDadSittingToStanding;
		public void ZParentDad_SittingToController()
		{
			ZParentDad_SittingToStartWalking();
			ZParentDad_SittingToStanding();
		}
		private void ZParentDad_SittingToStartWalking()
		{
			ZoroarkParentDadSittingToStartWalking.ZParentDad_SittingToStartWalkingController();
		}
		private void ZParentDad_SittingToStanding()
		{
			ZoroarkParentDadSittingToStanding.ZParentDad_SittingToStandingController();
		}

	}
}
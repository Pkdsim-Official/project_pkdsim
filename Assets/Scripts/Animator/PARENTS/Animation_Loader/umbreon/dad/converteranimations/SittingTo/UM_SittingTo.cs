using project_pkdsim.ANIMATOR.Parents.Umbreon.Dad.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Umbreon.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Umbreon.Dad.converteranimations.SittingTo
{
	public class UMParentDad_SittingTo : MonoBehaviour 
	{
		private UMParentDad_SittingToStanding UMParentDad_SittingToStanding;
		private UMParentDad_SittingToStartWalking UMParentDad_SittingToStartWalking;
		public void UMParentDad_SittingToController()
		{
			Load_UMParentDad_SittingToStanding();
			Load_UMParentDad_SittingToStartWalking();
		}
		private void Load_UMParentDad_SittingToStanding()
		{
			UMParentDad_SittingToStanding.UMParentDad_SittingToStandingController();
		}
		private void Load_UMParentDad_SittingToStartWalking()
		{
			UMParentDad_SittingToStartWalking.UMParentDad_SittingToStartWalkingController();
		}
	}
}
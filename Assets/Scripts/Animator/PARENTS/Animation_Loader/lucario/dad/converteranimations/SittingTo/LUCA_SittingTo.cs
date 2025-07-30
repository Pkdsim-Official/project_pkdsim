using project_pkdsim.ANIMATOR.Parents.Lucario.Dad.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Lucario.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lucario.Dad.converteranimations.SittingTo
{
	public class LUCAParentDad_SittingTo : MonoBehaviour 
	{
		private LUCAParentDad_SittingToStartWalking LucarioParentDadsittingToStartWalking;
		private LUCAParentDad_SittingToStanding LucarioParentDadsittingToStanding;
		public void LUCAParentDad_SittingToController()
		{
			LUCAParentDad_SittingToStartWalking();
			LUCAParentDad_SittingToStanding();
		}
		private void LUCAParentDad_SittingToStartWalking()
		{
			LucarioParentDadsittingToStartWalking.LUCAParentDad_SittingToStartWalkingController();
		}
		private void LUCAParentDad_SittingToStanding()
		{
			LucarioParentDadsittingToStanding.LUCAParentDad_SittingToStandingController();
		}
	}
}
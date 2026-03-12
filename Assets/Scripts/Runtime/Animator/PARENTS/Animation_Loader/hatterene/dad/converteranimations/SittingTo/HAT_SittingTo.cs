using Project_Pkdsim.ANIMATOR.Parents.Hatterene.Dad.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Parents.Hatterene.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Hatterene.Dad.converteranimations.SittingTo
{
	public class HATParentDad_SittingTo : MonoBehaviour 
	{
		private HATParentDad_SittingToStartWalking HattereneSittingToStartWalking;
		private HATParentDad_SittingToStanding HattereneSittingToStanding;
		public void HATParentDad_SittingToController()
		{
			HATSittingToStartWalking();
			HATSittingToStanding();
		}
		private void HATSittingToStartWalking()
		{
			HattereneSittingToStartWalking.HATParentDad_SittingToStartWalkingController();
		}
		private void HATSittingToStanding()
		{
			HattereneSittingToStanding.HATParentDad_SittingToStandingController();
		}
	}
}
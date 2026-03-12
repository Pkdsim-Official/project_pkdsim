using Project_Pkdsim.ANIMATOR.Parents.Hatterene.Dad.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Parents.Hatterene.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Hatterene.Dad.converteranimations.WalkingTo
{
	public class HATParentDad_WalkingTo : MonoBehaviour 
	{
		private HATParentDad_WalkingToStanding HattereneWalkingToStanding;
		private HATParentDad_WalkingToSitting HattereneWalkingToSitting;
		public void HATParentDad_WalkingToController()
		{
			Load_HATParentDad_WalkingToStanding();
			Load_HATParentDad_WalkingToWSitting();
		}
		private void Load_HATParentDad_WalkingToStanding()
		{
			HattereneWalkingToStanding.HATParentDad_WalkingToStandingController();
		}
		private void Load_HATParentDad_WalkingToWSitting()
		{
			HattereneWalkingToSitting.HATParentDad_WalkingToSittingController();
		}
	}
}
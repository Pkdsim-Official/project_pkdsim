using Project_Pkdsim.ANIMATOR.Parents.Beedrill.Dad.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Parents.Beedrill.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Beedrill.Dad.converteranimations.WalkingTo
{
	public class BEParentDad_WalkingTo : MonoBehaviour 
	{
		private BEParentDad_WalkingToStanding BeedrillParentDadWalkingToStanding;
		private BEParentDad_WalkingToSitting BeedrillParentDadWalkingToSitting;
		public void BEParentDad_WalkingToController()
		{
			Load_BEParentDad_WalkingToStanding();
			Load_BEParentDad_WalkingToWSitting();
		}
		private void Load_BEParentDad_WalkingToStanding()
		{
			BeedrillParentDadWalkingToStanding.BEParentDad_WalkingToStandingController();
		}
		private void Load_BEParentDad_WalkingToWSitting()
		{
			BeedrillParentDadWalkingToSitting.BEParentDad_WalkingToSittingController();
		}
	}
}
using Project_Pkdsim.ANIMATOR.Parents.Flareon.Dad.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Parents.Flareon.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Flareon.Dad.converteranimations.WalkingTo
{
	public class FLParentDadDad_WalkingTo : MonoBehaviour 
	{
		private FLParentDadDad_WalkingToStanding FlareonWalkingToStanding;
		private FLParentDadDad_WalkingToSitting FlareonWalkingToWSitting;
		public void FLParentDadDad_WalkingToController()
		{
			Load_FLParentDadDad_WalkingToStanding();
			Load_FLParentDadDad_WalkingToWSitting();
		}
		private void Load_FLParentDadDad_WalkingToStanding()
		{
			FlareonWalkingToStanding.FLParentDadDad_WalkingToStandingController();
		}
		private void Load_FLParentDadDad_WalkingToWSitting()
		{
			FlareonWalkingToWSitting.FLParentDadDad_WalkingToSittingController();
		}
	}
}
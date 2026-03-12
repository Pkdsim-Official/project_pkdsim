using Project_Pkdsim.ANIMATOR.Parents.Zoroark.Dad.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Parents.Zoroark.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Zoroark.Dad.converteranimations.WalkingTo
{
	public class ZParentDad_WalkingTo : MonoBehaviour 
	{
		private ZParentDad_WalkingToStanding ZoroarkParentDad_WalkingToStanding;
		private ZParentDad_WalkingToSitting ZoroarkParentDad_WalkingToSitting;
		
		public void ZParentDad_WalkingToController() 
		{
			Load_ZParentDad_WalkingToStandingController();
			Load_ZParentDad_WalkingToSittingController();
		}

		private void Load_ZParentDad_WalkingToStandingController()
		{
			ZoroarkParentDad_WalkingToStanding.ZParentDad_WalkingToStandingController();
		}
		
		private void Load_ZParentDad_WalkingToSittingController()
		{
			ZoroarkParentDad_WalkingToSitting.ZParentDad_WalkingToSittingController();
		}
	}
}
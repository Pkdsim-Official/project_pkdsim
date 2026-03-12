using Project_Pkdsim.ANIMATOR.Parents.Leafeon.Dad.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Parents.Leafeon.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Leafeon.Dad.converteranimations.WalkingTo
{
	public class LEParentDad_WalkingTo : MonoBehaviour 
	{
		private LEParentDad_WalkingToSitting LeafeonParentDadWalkingToSitting;
		private LEParentDad_WalkingToStanding LeafeonParentDadWalkingToStanding;
		public void LEParentDad_WalkingToController()
		{
			LEParentDad_WalkingToStartWalking();
			LEParentDad_WalkingToStanding();
		}
		private void LEParentDad_WalkingToStartWalking()
		{
			LeafeonParentDadWalkingToSitting.LEParentDad_WalkingToSittingController();
		}
		private void LEParentDad_WalkingToStanding()
		{
			LeafeonParentDadWalkingToStanding.LEParentDad_WalkingToStandingController();
		}
	}
}
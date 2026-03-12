using Project_Pkdsim.ANIMATOR.Parents.Lopunny.Dad.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Parents.Lopunny.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Lopunny.Dad.converteranimations.SittingTo
{
	public class LOParentDad_SittingTo : MonoBehaviour 
	{
		private LOParentDad_SittingToStartWalking LopunnyParentDadsittingToStartWalking;
		private LOParentDad_SittingToStanding LopunnyParentDadsittingToStanding;
		public void LOParentDad_SittingToController()
		{
			LOParentDad_SittingToStartWalking();
			LOParentDad_SittingToStanding();
		}
		private void LOParentDad_SittingToStartWalking()
		{
			LopunnyParentDadsittingToStartWalking.LOParentDad_SittingToStartWalkingController();
		}
		private void LOParentDad_SittingToStanding()
		{
			LopunnyParentDadsittingToStanding.LOParentDad_SittingToStandingController();
		}

	}
}
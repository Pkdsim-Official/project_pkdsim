using Project_Pkdsim.ANIMATOR.Parents.Lopunny.Dad.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Parents.Lopunny.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Lopunny.Dad.converteranimations.WalkingTo
{
	public class LOParentDad_WalkingTo : MonoBehaviour 
	{
		private LOParentDad_WalkingToStanding LopunnyWalkingToStanding;
		private LOParentDad_WalkingToSitting LopunnyWalkingToSitting;
		public void LOParentDad_WalkingToController()
		{
			Load_LOParentDad_WalkingToStanding();
			Load_LOParentDad_WalkingToSitting();
		}
		private void Load_LOParentDad_WalkingToStanding()
		{
			LopunnyWalkingToStanding.LOParentDad_WalkingToStandingController();
		}
		private void Load_LOParentDad_WalkingToSitting()
		{
			LopunnyWalkingToSitting.LOParentDad_WalkingToSittingController();
		}
	}
}
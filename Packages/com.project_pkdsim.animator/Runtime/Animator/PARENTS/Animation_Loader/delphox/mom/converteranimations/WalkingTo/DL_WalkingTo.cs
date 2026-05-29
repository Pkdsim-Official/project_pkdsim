using project_pkdsim.ANIMATOR.Parents.Delphox.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Delphox.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Delphox.Mom.converteranimations.WalkingTo
{
	public class DLWalkingTo : MonoBehaviour 
	{
		private DLWalkingToSitting DelphoxWalkingToSitting;
		private DLWalkingToStanding DelphoxWalkingToStanding;
		public void DLWalkingToController() 
		{
			Load_DLWalkingToSitting();
			Load_DLWalkingToStanding();
		}
		private void Load_DLWalkingToStanding()
		{
			DelphoxWalkingToStanding.DLWalkingToStandingController();
		}
		private void Load_DLWalkingToSitting()
		{
			DelphoxWalkingToSitting.DLWalkingToSittingController();
		}
	}
}
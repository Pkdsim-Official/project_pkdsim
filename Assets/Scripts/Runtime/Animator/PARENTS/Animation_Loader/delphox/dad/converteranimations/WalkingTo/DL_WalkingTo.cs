using Project_Pkdsim.ANIMATOR.Parents.Delphox.Dad.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Parents.Delphox.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Delphox.Dad.converteranimations.WalkingTo
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
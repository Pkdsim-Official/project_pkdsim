using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.converteranimations.WalkingTo
{
	public class LUNAWalkingTo : MonoBehaviour 
	{
		private LUNAWalkingToSitting LunalaWalkingToSitting;
		private LUNAWalkingToStanding LunalaWalkingToStanding;
		public void LUNAWalkingToController()
		{
			LUNAWalkingToSitting();
			LUNAWalkingToStanding();
		}
		private void LUNAWalkingToSitting()
		{
			LunalaWalkingToSitting.LUNAWalkingToSittingController();
		}
		private void LUNAWalkingToStanding()
		{
			LunalaWalkingToStanding.LUNAWalkingToStandingController();
		}
	}
}
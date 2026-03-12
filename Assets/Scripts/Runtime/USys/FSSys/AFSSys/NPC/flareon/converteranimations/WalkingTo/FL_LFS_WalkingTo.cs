using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.converteranimations.WalkingTo
{
	public class FL_LFS_WalkingTo : MonoBehaviour 
	{
		private FL_LFS_WalkingToStanding FL_LFS_WalkingToStandingController;
		private FL_LFS_WalkingToSitting FL_LFS_WalkingToSittingController;

		public void FL_LFS_WalkingToController() 
		{
			Load_FL_LFS_WalkingToStandingController();
			Load_FL_LFS_WalkingToSittingController();
		}

		private	void Load_FL_LFS_WalkingToStandingController()
		{
			FL_LFS_WalkingToStandingController.FL_LFS_WalkingToStandingController();
		}

		private	void Load_FL_LFS_WalkingToSittingController()
		{
			FL_LFS_WalkingToSittingController.FL_LFS_WalkingToSittingController();
		}
	}
}
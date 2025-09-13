using project_pkdsim.ANIMATOR.Parents.Vespiquen.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.converteranimations.IdleTo
{
	public class VEIdleTo : MonoBehaviour 
	{
		private VEIdleToRun VespiquenIdleToRun;
		private VEIdleToWalk VespiquenIdleToWalk;

		public void VE_IdleToController()
		{
			Load_VEidleToRun();
			Load_VEidleToWalk();
		}
		private void Load_VEidleToRun()
		{
			VespiquenIdleToRun.VEIdleToRunController();
		}
		private void Load_VEidleToWalk()
		{
			VespiquenIdleToWalk.VEIdleToWalkController();
		}
	}
}
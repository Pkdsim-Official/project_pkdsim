using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.converteranimations.IdleTo
{
	public class NOIIdleTo : MonoBehaviour 
	{
		private NOIIdleToRun NoivernIdleToRun;
		private NOIIdleToWalk NoivernIdleToWalk;
		public void NOI_IdleToController()
		{
			NOIIdleToRun();
			NOIIdleToWalk();
		}
		private void NOIIdleToRun()
		{
			NoivernIdleToRun.NOIIdleToRunController();
		}
		private void NOIIdleToWalk()
		{
			NoivernIdleToWalk.NOIIdleToWalkController();
		}
	}
}
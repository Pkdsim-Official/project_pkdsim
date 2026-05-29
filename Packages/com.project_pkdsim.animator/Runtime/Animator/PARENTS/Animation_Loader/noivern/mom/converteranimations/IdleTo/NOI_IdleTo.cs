using project_pkdsim.ANIMATOR.Parents.Noivern.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Noivern.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.Mom.converteranimations.IdleTo
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
using project_pkdsim.Models.ANIMATOR.NPC.Noivern.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Models.ANIMATOR.NPC.Noivern.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Noivern.converteranimations.IdleTo
{
	public class NOIIdleTo : MonoBehaviour 
	{
		private NOIIdleToRun NoivernIdleToRun;
		private NOIIdleToWalk NoivernIdleToWalk;
		public void NOIIdleToController()
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
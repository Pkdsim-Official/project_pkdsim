using project_pkdsim.ANIMATOR.Npcs.Noivern.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Npcs.Noivern.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Noivern.converteranimations.IdleTo
{
	public class NOI_IdleTo : MonoBehaviour 
	{
		private NOI_IdleToRun Noivern_IdleToRun;
		private NOI_IdleToWalk Noivern_IdleToWalk;
		public void NOI_IdleToController()
		{
			NOI_IdleToRun();
			NOI_IdleToWalk();
		}
		private void NOI_IdleToRun()
		{
			Noivern_IdleToRun.NOI_IdleToRunController();
		}
		private void NOI_IdleToWalk()
		{
			Noivern_IdleToWalk.NOI_IdleToWalkController();
		}
	}
}
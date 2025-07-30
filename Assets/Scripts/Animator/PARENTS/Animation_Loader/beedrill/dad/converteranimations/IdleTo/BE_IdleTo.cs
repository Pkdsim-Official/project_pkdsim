using project_pkdsim.ANIMATOR.Parents.Beedrill.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Beedrill.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Beedrill.converteranimations.IdleTo
{
	public class BE_IdleTo : MonoBehaviour 
	{
		private BE_IdleToRun BeedrillIdleToRun;
		private BE_IdleToWalk BeedrillIdleToWalk;

		public void BE_IdleToController()
		{
			Load_BE_idleToRun();
			Load_BE_idleToWalk();
		}
		private void Load_BE_idleToRun()
		{
			BeedrillIdleToRun.BE_IdleToRunController();
		}
		private void Load_BE_idleToWalk()
		{
			BeedrillIdleToWalk.BE_IdleToWalkController();
		}
	}
}
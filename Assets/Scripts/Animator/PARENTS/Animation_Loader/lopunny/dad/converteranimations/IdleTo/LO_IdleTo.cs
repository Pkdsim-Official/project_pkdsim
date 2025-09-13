using project_pkdsim.ANIMATOR.Parents.Lopunny.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Lopunny.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lopunny.converteranimations.IdleTo
{
	public class LOIdleTo : MonoBehaviour 
	{
		private LOIdleToRun LopunnyIdleToRun;
		private LOIdleToWalk LopunnyIdleToWalk;
		public void LO_IdleToController()
		{
			Load_LOidleToRun();
			Load_LOidleToWalk();
		}
		private void Load_LOidleToRun()
		{
			LopunnyIdleToRun.LOIdleToRunController();
		}
		private void Load_LOidleToWalk()
		{
			LopunnyIdleToWalk.LOIdleToWalkController();
		}
	}
}
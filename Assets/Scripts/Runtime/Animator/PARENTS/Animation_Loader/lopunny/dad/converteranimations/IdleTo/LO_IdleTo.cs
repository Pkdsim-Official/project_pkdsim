using Project_Pkdsim.ANIMATOR.Parents.Lopunny.Dad.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Parents.Lopunny.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Lopunny.Dad.converteranimations.IdleTo
{
	public class LOParentDad_IdleTo : MonoBehaviour 
	{
		private LOParentDad_IdleToRun LopunnyParentDadIdleToRun;
		private LOParentDad_IdleToWalk LopunnyParentDadIdleToWalk;
		public void LOParentDad_IdleToController()
		{
			Load_LOParentDad_IdleToRun();
			Load_LOParentDad_IdleToWalk();
		}
		private void Load_LOParentDad_IdleToRun()
		{
			LopunnyParentDadIdleToRun.LOParentDad_IdleToRunController();
		}
		private void Load_LOParentDad_IdleToWalk()
		{
			LopunnyParentDadIdleToWalk.LOParentDad_IdleToWalkController();
		}
	}
}
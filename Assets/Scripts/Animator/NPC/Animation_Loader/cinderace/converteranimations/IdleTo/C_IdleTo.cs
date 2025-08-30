using project_pkdsim.Models.ANIMATOR.NPC.Cinderace.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Models.ANIMATOR.NPC.Cinderace.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Cinderace.converteranimations.IdleTo
{
	public class CIdleTo : MonoBehaviour 
	{
		private CIdleToRun CinderaceIdleToRun;
		private CIdleToWalk CinderaceIdleToWalk;
		public void CIdleToController()
		{
			Load_CidleToRun();
			Load_CidleToWalk();
		}
		private void Load_CidleToRun()
		{
			CinderaceIdleToRun.CIdleToRunController();
		}
		private void Load_CidleToWalk()
		{
			CinderaceIdleToWalk.CIdleToWalkController();
		}
	}
}
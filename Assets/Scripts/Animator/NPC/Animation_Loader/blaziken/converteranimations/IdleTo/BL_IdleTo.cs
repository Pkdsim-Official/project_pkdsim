using project_pkdsim.Models.ANIMATOR.NPC.Blaziken.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Models.ANIMATOR.NPC.Blaziken.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Blaziken.converteranimations.IdleTo
{
	public class BLIdleTo : MonoBehaviour 
	{
		private BLIdleToRun BlazikenIdleToRun;
		private BLIdleToWalk BlazikenIdleToWalk;
		public void BLIdleToController()
		{
			Load_BLidleToRun();
			Load_BLidleToWalk();
		}
		private void Load_BLidleToRun()
		{
			BlazikenIdleToRun.BLIdleToRunController();
		}
		private void Load_BLidleToWalk()
		{
			BlazikenIdleToWalk.BLIdleToWalkController();
		}
	}
}
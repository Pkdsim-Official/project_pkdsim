using project_pkdsim.ANIMATOR.NPC.Zoroark.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.NPC.Zoroark.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Zoroark.converteranimations.IdleTo
{
	public class Z_IdleTo : MonoBehaviour 
	{
		private Z_IdleToRun Zoroark_IdleToRun;
		private Z_IdleToWalk Zoroark_IdleToWalk;
		public void Z_IdleToController()
		{
			Load_ZidleToRun();
			Load_ZidleToWalk();
		}
		private void Load_ZidleToRun()
		{
			Zoroark_IdleToRun.Z_IdleToRunController();
		}
		private void Load_ZidleToWalk()
		{
			Zoroark_IdleToWalk.Z_IdleToWalkController();
		}
	}
}
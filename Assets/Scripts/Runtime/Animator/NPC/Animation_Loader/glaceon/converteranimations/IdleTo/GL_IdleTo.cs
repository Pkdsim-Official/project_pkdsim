using Project_Pkdsim.ANIMATOR.Npcs.Glaceon.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Npcs.Glaceon.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Glaceon.converteranimations.IdleTo
{
	public class GL_IdleTo : MonoBehaviour 
	{
		private GL_IdleToRun GL_IdleToRunning;
		private GL_IdleToWalk GL_IdleToWalking;
		public void GL_IdleToController()
		{
			Load_GL_IdleToRunning();
			Load_GL_IdleToWalking();
		}
		private void Load_GL_IdleToRunning()
		{
			GL_IdleToRunning.GL_IdleToRunController();
		}
		private void Load_GL_IdleToWalking()
		{
			GL_IdleToWalking.GL_IdleToWalkController();
		}
	}
}
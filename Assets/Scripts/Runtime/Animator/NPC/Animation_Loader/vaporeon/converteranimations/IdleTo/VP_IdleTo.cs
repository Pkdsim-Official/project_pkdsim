using Project_Pkdsim.ANIMATOR.Npcs.Vaporeon.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Npcs.Vaporeon.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Vaporeon.converteranimations.IdleTo
{
	public class VP_IdleTo : MonoBehaviour 
	{
		private VP_IdleToWalk VAPOR_idletowalk;
		
		private VP_IdleToRun VAPOR_idletorun;
		public void VP_IdleToController()
		{
			Load_VP_idleToRun();
			Load_VP_idleToWalk();
		}
		private void Load_VP_idleToRun()
		{
			
		}
		private void Load_VP_idleToWalk()
		{
			
		}
	}
}
using Project_Pkdsim.ANIMATOR.Npcs.Lunala.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Npcs.Lunala.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Lunala.converteranimations.IdleTo
{
	public class LUNA_IdleTo : MonoBehaviour 
	{
		private LUNA_IdleToRun Lunala_IdleToRun;
		private LUNA_IdleToWalk Lunala_IdleToWalk;

		public void LUNA_IdleToController()
		{
			Load_LUNAidleToRun();
			Load_LUNAidleToWalk();
		}
		private void Load_LUNAidleToRun()
		{
			Lunala_IdleToRun.LUNA_IdleToRunController();
		}
		private void Load_LUNAidleToWalk()
		{
			Lunala_IdleToWalk.LUNA_IdleToWalkController();
		}
	}
}
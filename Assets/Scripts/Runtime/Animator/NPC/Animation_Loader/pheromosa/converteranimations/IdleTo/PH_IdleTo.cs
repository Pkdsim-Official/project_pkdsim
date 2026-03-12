using Project_Pkdsim.ANIMATOR.Npcs.Pheromosa.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Npcs.Pheromosa.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Pheromosa.converteranimations.IdleTo
{
	public class PH_IdleTo : MonoBehaviour 
	{
		private PH_IdleToRun Pheromosa_IdleToRun;
		private PH_IdleToWalk Pheromosa_IdleToWalk;
		public void PH_IdleToController()
		{
			Load_PHidleToRun();
			Load_PHidleToWalk();
		}
		private void Load_PHidleToRun()
		{
			Pheromosa_IdleToRun.PH_IdleToRunController();
		}
		private void Load_PHidleToWalk()
		{
			Pheromosa_IdleToWalk.PH_IdleToWalkController();
		}
	}
}
using Project_Pkdsim.ANIMATOR.Npcs.Absol.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Npcs.Absol.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Absol.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Absol.converteranimations
{
	public class Absol_CoverterAnimatorController : MonoBehaviour 
	{
		private AB_SittingTo AbsolSittingto;
		
		private AB_WalkingTo AbsolWalkingto;
		
		private AB_IdleTo AbsolIdleto;

		public void AB_CoverterToAnimatorController()
		{
			AbsolWalkingto.AB_WalkingToController();

			AbsolIdleto.AB_IdleToController();
			
			AbsolSittingto.AB_SittingToController();	
		}
	}
}
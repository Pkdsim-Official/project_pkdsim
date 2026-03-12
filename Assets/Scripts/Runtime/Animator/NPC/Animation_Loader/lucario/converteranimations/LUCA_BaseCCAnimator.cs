using Project_Pkdsim.ANIMATOR.Npcs.Lucario.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Npcs.Lucario.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Lucario.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Lucario.converteranimations
{
	public class LucarioCoverterAnimatorController : MonoBehaviour 
	{
		private LUCA_SittingTo Lucariosittingto;
		
		private LUCA_WalkingTo Lucariowalkingto;
		
		private LUCA_IdleTo Lucarioidleto;

		public void LUCACoverterToAnimatorController()
		{
			Lucariowalkingto.LUCA_WalkingToController();

			Lucarioidleto.LUCA_IdleToController();
			
			Lucariosittingto.LUCA_SittingToController();	
		}
	}
}
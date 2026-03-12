using Project_Pkdsim.ANIMATOR.Npcs.Vespiquen.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Npcs.Vespiquen.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Vespiquen.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Vespiquen.converteranimations
{
	public class VespiquenCoverterAnimatorController : MonoBehaviour 
	{
		private VE_SittingTo Vespiquensittingto;
		
		private VE_WalkingTo Vespiquenwalkingto;
		
		private VE_IdleTo Vespiquenidleto;

		public void VECoverterToAnimatorController()
		{
			Vespiquenwalkingto.VE_WalkingToController();

			Vespiquenidleto.VE_IdleToController();
			
			Vespiquensittingto.VE_SittingToController();	
		}
	}
}
using Project_Pkdsim.ANIMATOR.Npcs.Lopunny.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Npcs.Lopunny.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Lopunny.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Lopunny.converteranimations
{
	public class Lopunny_CoverterAnimatorController : MonoBehaviour 
	{
		private LO_SittingTo LopunnySittingto;
		
		private LO_WalkingTo LopunnyWalkingto;
		
		private LO_IdleTo LopunnyIdleto;

		public void LO_CoverterToAnimatorController()
		{
			LopunnyWalkingto.LO_WalkingToController();

			LopunnyIdleto.LO_IdleToController();
			
			LopunnySittingto.LO_SittingToController();	
		}
	}
}
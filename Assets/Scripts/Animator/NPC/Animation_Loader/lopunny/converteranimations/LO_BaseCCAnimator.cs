using project_pkdsim.ANIMATOR.Npcs.Lopunny.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Npcs.Lopunny.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Npcs.Lopunny.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Lopunny.converteranimations
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
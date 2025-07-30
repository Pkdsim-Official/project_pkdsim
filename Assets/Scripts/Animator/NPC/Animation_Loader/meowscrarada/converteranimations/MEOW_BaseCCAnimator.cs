using project_pkdsim.ANIMATOR.Npcs.Meowscarada.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Npcs.Meowscarada.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Npcs.Meowscarada.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Meowscarada.converteranimations
{
	public class MeowscaradaCoverterAnimatorController : MonoBehaviour 
	{
		private MEOW_SittingTo Meowscaradasittingto;
		
		private MEOW_WalkingTo Meowscaradawalkingto;
		
		private MEOW_IdleTo Meowscaradaidleto;

		public void MEOWCoverterToAnimatorController()
		{
			Meowscaradawalkingto.MEOW_WalkingToController();

			Meowscaradaidleto.MEOW_IdleToController();
			
			Meowscaradasittingto.MEOW_SittingToController();	
		}
	}
}
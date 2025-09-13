using project_pkdsim.ANIMATOR.Parents.Meowscarada.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Meowscarada.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Meowscarada.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Meowscarada.converteranimations
{
	public class MeowscaradaCoverterAnimatorController : MonoBehaviour 
	{
		private MEOWSittingTo Meowscaradasittingto;
		
		private MEOWWalkingTo Meowscaradawalkingto;
		
		private MEOWIdleTo Meowscaradaidleto;

		public void MEOWCoverterToAnimatorController()
		{
			Meowscaradawalkingto.MEOWWalkingToController();

			Meowscaradaidleto.MEOW_IdleToController();
			
			Meowscaradasittingto.MEOWSittingToController();	
		}
	}
}
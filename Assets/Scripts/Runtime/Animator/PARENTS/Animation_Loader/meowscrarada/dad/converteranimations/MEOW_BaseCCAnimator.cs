using Project_Pkdsim.ANIMATOR.Parents.Meowscarada.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Parents.Meowscarada.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Parents.Meowscarada.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Meowscarada.converteranimations
{
	public class MeowscaradaConverterAnimatorController : MonoBehaviour 
	{
		private MEOWSittingTo Meowscaradasittingto;
		
		private MEOWWalkingTo Meowscaradawalkingto;
		
		private MEOWIdleTo Meowscaradaidleto;

		public void MEOWConverterAnimatorController()
		{
			Meowscaradawalkingto.MEOWWalkingToController();

			Meowscaradaidleto.MEOW_IdleToController();
			
			Meowscaradasittingto.MEOWSittingToController();	
		}
	}
}
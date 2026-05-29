using project_pkdsim.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Meowscarada.Mom.converteranimations
{
	public class Meowscarada_ConverterToAnimatorController : MonoBehaviour 
	{
		private MEOWSittingTo Meowscaradasittingto;
		
		private MEOWWalkingTo Meowscaradawalkingto;
		
		private MEOWIdleTo Meowscaradaidleto;

		public void MEOW_ConverterToAnimatorController()
		{
			Meowscaradawalkingto.MEOWWalkingToController();

			Meowscaradaidleto.MEOW_IdleToController();
			
			Meowscaradasittingto.MEOWSittingToController();	
		}
	}
}
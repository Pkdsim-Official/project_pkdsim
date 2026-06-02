using project_pkdsim.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Meowscarada.Mom.converteranimations
{
	public class Meowscarada_ConverterAnimatorController : MonoBehaviour 
	{
		private MEOW_SittingTo Meowscaradasittingto;
		
		private MEOW_WalkingTo Meowscaradawalkingto;
		
		private MEOW_IdleTo Meowscaradaidleto;

		public void MEOW_ConverterAnimatorController()
		{
			Meowscaradawalkingto.MEOW_WalkingToController();

			Meowscaradaidleto.MEOW_IdleToController();
			
			Meowscaradasittingto.MEOW_SittingToController();	
		}
	}
}
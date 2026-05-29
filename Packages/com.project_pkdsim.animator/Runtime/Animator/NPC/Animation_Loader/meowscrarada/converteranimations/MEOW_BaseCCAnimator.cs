using project_pkdsim.ANIMATOR.NPC.Meowscarada.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.NPC.Meowscarada.converteranimations._SittingTo;
using project_pkdsim.ANIMATOR.NPC.Meowscarada.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Meowscarada.converteranimations
{
	public class Meowscarada_ConverterToAnimatorController : MonoBehaviour 
	{
		private MEOW_SittingTo Meowscaradasittingto;
		
		private MEOW_WalkingTo Meowscaradawalkingto;
		
		private MEOW_IdleTo Meowscaradaidleto;

		public void MEOW_ConverterToAnimatorController()
		{
			Meowscaradawalkingto.MEOW_WalkingToController();

			Meowscaradaidleto.MEOW_IdleToController();
			
			Meowscaradasittingto.MEOW_SittingToController();	
		}
	}
}
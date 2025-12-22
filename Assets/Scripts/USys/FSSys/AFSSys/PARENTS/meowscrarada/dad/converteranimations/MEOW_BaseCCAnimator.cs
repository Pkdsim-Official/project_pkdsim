using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.converteranimations.IdleTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.converteranimations.SittingTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.converteranimations
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
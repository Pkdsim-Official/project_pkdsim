using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.converteranimations
{
	public class MeowscaradaParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private MEOWParentMom_SittingTo Meowscaradasittingto;
		
		private MEOWParentMom_WalkingTo Meowscaradawalkingto;
		
		private MEOWParentMom_IdleTo Meowscaradaidleto;

		public void MEOWParentMom_ConverterAnimatorController()
		{
			Meowscaradawalkingto.MEOWParentMom_WalkingToController();

			Meowscaradaidleto.MEOWParentMom_IdleToController();
			
			Meowscaradasittingto.MEOWParentMom_SittingToController();	
		}
	}
}
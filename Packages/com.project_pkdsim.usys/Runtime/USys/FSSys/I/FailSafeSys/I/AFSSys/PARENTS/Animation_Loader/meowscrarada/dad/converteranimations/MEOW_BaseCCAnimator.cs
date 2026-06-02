using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.converteranimations
{
	public class MeowscaradaParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private MEOWParentDad_SittingTo Meowscaradasittingto;
		
		private MEOWParentDad_WalkingTo Meowscaradawalkingto;
		
		private MEOWParentDad_IdleTo Meowscaradaidleto;

		public void MEOWParentDad_ConverterAnimatorController()
		{
			Meowscaradawalkingto.MEOWParentDad_WalkingToController();

			Meowscaradaidleto.MEOWParentDad_IdleToController();
			
			Meowscaradasittingto.MEOWParentDad_SittingToController();	
		}
	}
}
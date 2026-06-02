using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.converteranimations
{
	public class NoivernParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private NOISittingTo Noivernsittingto;
		
		private NOIWalkingTo Noivernwalkingto;
		
		private NOIIdleTo Noivernidleto;

		public void NOI_ConverterAnimatorController()
		{
			Noivernwalkingto.NOIWalkingToController();

			Noivernidleto.NOI_IdleToController();
			
			Noivernsittingto.NOISittingToController();	
		}
	}
}
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.converteranimations
{
	public class BeedrillParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private BE_SittingTo BeedrillSittingto;
		
		private BE_WalkingTo BeedrillWalkingto;
		
		private BE_IdleTo BeedrillIdleto;

		public void BE_ConverterAnimatorController()
		{
			BeedrillWalkingto.BE_WalkingToController();

			BeedrillIdleto.BE_IdleToController();
			
			BeedrillSittingto.BE_SittingToController();	
		}
	}
}
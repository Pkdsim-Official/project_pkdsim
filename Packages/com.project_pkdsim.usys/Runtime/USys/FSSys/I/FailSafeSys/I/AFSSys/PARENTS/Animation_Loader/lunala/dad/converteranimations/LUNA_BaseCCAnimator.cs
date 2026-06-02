using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.converteranimations
{
	public class LunalaParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private LUNAParentDad_SittingTo Lunalasittingto;
		
		private LUNAParentDad_WalkingTo Lunalawalkingto;
		
		private LUNAParentDad_IdleTo Lunalaidleto;

		public void LUNAParentDad_ConverterAnimatorController()
		{
			Lunalawalkingto.LUNAParentDad_WalkingToController();

			Lunalaidleto.LUNAParentDad_IdleToController();
			
			Lunalasittingto.LUNAParentDad_SittingToController();	
		}
	}
}
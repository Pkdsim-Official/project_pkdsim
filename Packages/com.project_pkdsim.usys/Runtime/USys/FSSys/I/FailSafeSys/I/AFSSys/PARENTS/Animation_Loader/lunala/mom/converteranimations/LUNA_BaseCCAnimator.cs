using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations
{
	public class LunalaParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private LUNAParentMom_SittingTo Lunalasittingto;
		
		private LUNAParentMom_WalkingTo Lunalawalkingto;
		
		private LUNAParentMom_IdleTo Lunalaidleto;

		public void LUNAParentMom_ConverterAnimatorController()
		{
			Lunalawalkingto.LUNAParentMom_WalkingToController();

			Lunalaidleto.LUNAParentMom_IdleToController();
			
			Lunalasittingto.LUNAParentMom_SittingToController();	
		}
	}
}
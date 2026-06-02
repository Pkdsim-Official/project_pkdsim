using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.converteranimations
{
	public class AbsolParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private ABParentMom_SittingTo AbsolSittingto;
		
		private ABParentMom_WalkingTo AbsolWalkingto;
		
		private ABParentMom_IdleTo AbsolIdleto;

		public void ABParentMom_ConverterAnimatorController()
		{
			AbsolWalkingto.ABParentMom_WalkingToController();

			AbsolIdleto.ABParentMom_IdleToController();
			
			AbsolSittingto.ABParentMom_SittingToController();	
		}
	}
}
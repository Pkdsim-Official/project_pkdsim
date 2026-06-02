using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Mom.converteranimations
{
	public class ZoroarkParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private ZParentMom_SittingTo ZoroarkParentMomSittingto;
		
		private ZParentMom_WalkingTo ZoroarkParentMomWalkingto;
		
		private ZParentMom_IdleTo ZoroarkParentMomIdleto;

		public void ZParentMom_ConverterAnimatorController()
		{
			ZoroarkParentMomWalkingto.ZParentMom_WalkingToController();

			ZoroarkParentMomIdleto.ZParentMom_IdleToController();
			
			ZoroarkParentMomSittingto.ZParentMom_SittingToController();	
		}
	}
}
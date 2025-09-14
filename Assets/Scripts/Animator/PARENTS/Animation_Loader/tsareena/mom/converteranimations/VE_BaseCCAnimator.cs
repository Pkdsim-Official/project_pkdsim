using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations
{
	public class TsareenaParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private TParentMom_SittingTo TsareenaParentMomSittingto;
		
		private TParentMom_WalkingTo TsareenaParentMomWalkingto;
		
		private TParentMom_IdleTo TsareenaParentMomIdleto;

		public void TParentMom_ConverterAnimatorController()
		{
			TsareenaParentMomWalkingto.TParentMom_WalkingToController();

			TsareenaParentMomIdleto.TParentMom_IdleToController();
			
			TsareenaParentMomSittingto.TParentMom_SittingToController();	
		}
	}
}
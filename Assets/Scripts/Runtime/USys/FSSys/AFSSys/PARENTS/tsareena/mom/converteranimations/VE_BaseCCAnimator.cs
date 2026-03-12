using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.converteranimations
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
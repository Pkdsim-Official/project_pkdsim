using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations
{
	public class TsareenaParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private TParentMom_SittingTo Tsareenasittingto;
		
		private TParentMom_WalkingTo Tsareenawalkingto;
		
		private TParentMom_IdleTo Tsareenaidleto;

		public void TParentMom_ConverterAnimatorController()
		{
			Tsareenawalkingto.TParentMom_WalkingToController();

			Tsareenaidleto.TParentMom_IdleToController();
			
			Tsareenasittingto.TParentMom_SittingToController();	
		}
	}
}
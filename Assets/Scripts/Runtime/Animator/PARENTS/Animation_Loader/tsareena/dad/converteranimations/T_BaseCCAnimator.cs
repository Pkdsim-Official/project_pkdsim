using Project_Pkdsim.ANIMATOR.Parents.Tsareena.Dad.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Parents.Tsareena.Dad.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Parents.Tsareena.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Tsareena.Dad.converteranimations
{
	public class TsareenaParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private TParentDad_SittingTo TsareenaParentDadSittingto;
		
		private TParentDad_WalkingTo TsareenaParentDadWalkingto;
		
		private TParentDad_IdleTo TsareenaParentDadIdleto;

		public void TParentDad_ConverterAnimatorController()
		{
			TsareenaParentDadWalkingto.TParentDad_WalkingToController();

			TsareenaParentDadIdleto.TParentDad_IdleToController();
			
			TsareenaParentDadSittingto.TParentDad_SittingToController();	
		}
	}
}
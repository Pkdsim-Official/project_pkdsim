using Project_Pkdsim.ANIMATOR.Npcs.Zoroark.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Npcs.Zoroark.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Zoroark.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Zoroark.converteranimations
{
	public class ZoroarkCoverterAnimatorController : MonoBehaviour 
	{
		private Z_SittingTo Zoroarksittingto;
		
		private Z_WalkingTo Zoroarkwalkingto;
		
		private Z_IdleTo Zoroarkidleto;

		public void ZCoverterToAnimatorController()
		{
			Zoroarkwalkingto.Z_WalkingToController();

			Zoroarkidleto.Z_IdleToController();
			
			Zoroarksittingto.Z_SittingToController();	
		}
	}
}
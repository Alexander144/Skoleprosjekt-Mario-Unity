//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
namespace AssemblyCSharp
{
	public abstract class BaseWorldDefinition
	{
		
		public BaseWorldDefinition ()
		{
		}
		public abstract int GetTileAtXY(int x,int y);
		public abstract int GetMaxX();
		public abstract int GetMaxY();
		public abstract WorldObject[] GetAllWorldObjects();
		public abstract WorldObject GetTileObjectAtXY(int x,int y);
	}
}

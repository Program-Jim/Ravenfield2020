using System;

namespace Ravenfield.Trigger
{
	public class SignalContextProviderAttribute : Attribute
	{
		public ContextType[] contextTypes;

		public SignalContextProviderAttribute(params ContextType[] contextTypes) {
			this.contextTypes = contextTypes;
		}
	}

	public enum ContextType
	{
		Actor,
		Squad,
		Vehicle,
	};
}
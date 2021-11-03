using System;

using Microsoft.Extensions.Configuration;


namespace R5T.T0073
{
    public interface IHasConfigureConfiguration<TConfigurationBuilder>
        where TConfigurationBuilder : IHasConfigureConfiguration<TConfigurationBuilder>
    {
        TConfigurationBuilder ConfigureConfiguration(Action<IConfigurationBuilder> configureAction);
    }
}

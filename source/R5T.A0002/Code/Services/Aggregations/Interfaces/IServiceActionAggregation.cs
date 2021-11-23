using System;

using R5T.Lombardy;

using R5T.D0063.Default;
using R5T.D0065.Standard;
using R5T.D0070.A001;
using R5T.T0063;


namespace R5T.A0002
{
    [ServiceActionAggregationMarker]
    public interface IServiceActionAggregation : T0063.IServiceActionAggregation, IServiceActionAggregationIncrement,
        IAppSettingsFilePathProviderActionAggregation,
        IEnvironmentVariableProviderActionAggregation,
        IExecutableDirectoryPathActionAggregation,
        IStringlyTypedPathOperatorActionAggregation
    {
    }
}

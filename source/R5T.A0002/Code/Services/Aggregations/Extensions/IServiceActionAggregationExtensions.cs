using System;

using R5T.Lombardy;

using R5T.D0063.Default;
using R5T.D0065.Standard;
using R5T.D0070.A001;


namespace R5T.A0002
{
    public static class IServiceActionAggregationExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceActionAggregation other)
            where T : IServiceActionAggregation
        {
            (aggregation as IServiceActionAggregationIncrement).FillFrom(other);

            (aggregation as IAppSettingsFilePathProviderActionAggregation).FillFrom(other);
            (aggregation as IEnvironmentVariableProviderActionAggregation).FillFrom(other);
            (aggregation as IExecutableDirectoryPathActionAggregation).FillFrom(other);
            (aggregation as IStringlyTypedPathOperatorActionAggregation).FillFrom(other);

            return aggregation;
        }
    }
}

using System;


namespace R5T.A0002
{
    public static class IServiceActionAggregationIncrementExtensions
    {
        public static T FillFrom<T>(this T aggregation,
#pragma warning disable IDE0060 // Remove unused parameter
            IServiceActionAggregationIncrement other)
#pragma warning restore IDE0060 // Remove unused parameter
            where T : IServiceActionAggregationIncrement
        {
            // Nothing at the moment.

            return aggregation;
        }
    }
}

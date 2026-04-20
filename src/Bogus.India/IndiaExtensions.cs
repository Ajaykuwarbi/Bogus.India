namespace Bogus.India
{
    /// <summary>
    /// Extension methods to add India-specific fake data generation to Bogus.
    /// </summary>
    public static class IndiaExtensions
    {
        /// <summary>
        /// Accesses the India-specific fake data generator.
        /// </summary>
        /// <example>
        /// <code>
        /// var faker = new Faker();
        /// var name = faker.India().FullName();
        /// var aadhaar = faker.India().Aadhaar();
        /// var pan = faker.India().Pan();
        /// var upi = faker.India().UpiId();
        /// </code>
        /// </example>
        /// <param name="faker">The Bogus Faker instance.</param>
        /// <returns>An <see cref="IndiaDataSet"/> for generating India-specific data.</returns>
        public static IndiaDataSet India(this Faker faker)
        {
            return ContextHelper.GetOrSet(faker, () => new IndiaDataSet());
        }
    }

    /// <summary>
    /// Helper class for managing dataset instances per Faker context.
    /// </summary>
    internal static class ContextHelper
    {
        private static readonly System.Collections.Concurrent.ConcurrentDictionary<int, IndiaDataSet> _dataSets
            = new System.Collections.Concurrent.ConcurrentDictionary<int, IndiaDataSet>();

        /// <summary>
        /// Gets or creates an <see cref="IndiaDataSet"/> associated with the given Faker instance.
        /// </summary>
        internal static IndiaDataSet GetOrSet(Faker faker, System.Func<IndiaDataSet> factory)
        {
            return _dataSets.GetOrAdd(faker.GetHashCode(), _ =>
            {
                var ds = factory();
                // Sync the random seed with the parent Faker for deterministic generation
                ds.Random = faker.Random;
                return ds;
            });
        }
    }
}

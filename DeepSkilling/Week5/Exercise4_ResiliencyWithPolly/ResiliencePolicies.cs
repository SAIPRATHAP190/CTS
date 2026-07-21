using Polly;
using Polly.Extensions.Http;

namespace OrderService.Resilience
{
    public static class ResiliencePolicies
    {
        public static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
        {
            return HttpPolicyExtensions
                .HandleTransientHttpError()
                .WaitAndRetryAsync(
                    retryCount: 3,
                    sleepDurationProvider: retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)),
                    onRetry: (outcome, timespan, retryAttempt, context) =>
                    {
                        Console.WriteLine($"Transient error encountered. Retrying attempt {retryAttempt} after {timespan.TotalSeconds} seconds.");
                    });
        }

        public static IAsyncPolicy<HttpResponseMessage> GetCircuitBreakerPolicy()
        {
            return HttpPolicyExtensions
                .HandleTransientHttpError()
                .CircuitBreakerAsync(
                    handledEventsAllowedBeforeBreaking: 5,
                    durationOfBreak: TimeSpan.FromSeconds(15),
                    onBreak: (outcome, breakDuration) =>
                    {
                        Console.WriteLine($"Circuit Broken! Blocking outbound calls for {breakDuration.TotalSeconds} seconds.");
                    },
                    onReset: () =>
                    {
                        Console.WriteLine("Circuit Reset! Normal traffic resumed.");
                    });
        }
    }
}

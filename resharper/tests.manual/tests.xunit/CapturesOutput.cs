using System;
using System.Diagnostics;
using Xunit;

namespace tests.xunit.eyeball
{
    namespace CapturesOutput
    {
        public class CapturesStandardOutput
        {
            // TEST: Runner should display message
            [Fact(Skip = "xunit2 doesn't capture output")]
            public void CapturesStdOut()
            {
                Console.WriteLine("Hello from stdout");
            }

            // TEST: Runner should display message
            [Fact(Skip = "xunit2 doesn't capture output")]
            public void CapturesStdErr()
            {
                Console.Error.WriteLine("Hello from stderr");
            }
        }

        public class CapturesDebugTrace
        {
            // TEST: Runner should display message
            [Fact(Skip = "xunit2 doesn't capture output")]
            public void CapturesDebugTraceOutput()
            {
                Debug.WriteLine("Hello from Debug.WriteLine");
            }

            // TEST: Runner should display message
            [Fact(Skip = "xunit2 doesn't capture output")]
            public void CapturesTraceOutput()
            {
                Trace.WriteLine("Hello from Trace.WriteLine");
            }

            // TEST: Runner should display message
            [Fact(Skip = "xunit2 doesn't capture output")]
            public void CapturesTraceInformationOutput()
            {
                Trace.TraceInformation("Hello from Trace.TraceInformation (System.Diagnostics adds AppName)");
            }

            // TEST: Runner should display message
            [Fact(Skip = "xunit2 doesn't capture output")]
            public void CapturesTraceWarningOutput()
            {
                Trace.TraceWarning("Hello from Trace.TraceWarning (System.Diagnostics adds AppName)");
            }

            // TEST: Runner should display message
            [Fact(Skip = "xunit2 doesn't capture output")]
            public void CapturesTraceErrorOutput()
            {
                Trace.TraceError("Hello from Trace.TraceError (System.Diagnostics adds AppName)");
            }
        }
    }
}
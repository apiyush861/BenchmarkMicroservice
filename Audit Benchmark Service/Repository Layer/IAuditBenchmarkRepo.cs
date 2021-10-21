using Audit_Benchmark_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Audit_Benchmark_Service.Repository_Layer
{
    interface IAuditBenchmarkRepo
    {
        public List<AuditBenchmark> GetBenchmarkList();
    }
}

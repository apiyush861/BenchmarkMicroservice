using Audit_Benchmark_Service.Models;
using Audit_Benchmark_Service.Repository_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Audit_Benchmark_Service.Service_Layer
{
    public class BenchmarkService:IBenchmarkService
    {
        public virtual List<AuditBenchmark> GetListOfBenchmarks()
        {
            AuditBenchmarkRepo repo = new AuditBenchmarkRepo();
            return repo.GetBenchmarkList();
        }

    }
}

using Audit_Benchmark_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Audit_Benchmark_Service.Repository_Layer
{
    public class AuditBenchmarkRepo:IAuditBenchmarkRepo
    {
        public virtual List<AuditBenchmark> GetBenchmarkList()
        {
            List<AuditBenchmark> AuditBenchmarkList = new List<AuditBenchmark>()
            {
                new AuditBenchmark(){ AuditType="Internal",BenchmarkNoAnswers=3 },
                new AuditBenchmark(){ AuditType="SOX",BenchmarkNoAnswers=1 },
            };
            return AuditBenchmarkList;
        }
    }
}

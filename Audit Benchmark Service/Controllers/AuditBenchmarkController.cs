using Audit_Benchmark_Service.Models;
using Audit_Benchmark_Service.Service_Layer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Audit_Benchmark_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuditBenchmarkController : ControllerBase
    {
        IBenchmarkService benchmarkService ;
        public AuditBenchmarkController(IBenchmarkService _benchmarkService)
        {
            this.benchmarkService = _benchmarkService;
        }
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(AuditBenchmarkController)); 
        [AllowAnonymous]
        [HttpGet]
        public List<AuditBenchmark> GetAuditBenchmarks()
        {
            _log4net.Info("In Audit benchmark");
            
            _log4net.Info("List of benchmark is returned");
            return this.benchmarkService.GetListOfBenchmarks();
        }

    }
}

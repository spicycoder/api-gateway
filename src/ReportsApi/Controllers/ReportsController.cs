namespace ReportsApi.Controllers
{
    using Domain.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="ReportsController" />
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        /// <summary>
        /// The GetReports
        /// </summary>
        /// <returns>The <see cref="ActionResult{IEnumerable{Report}}"/></returns>
        [HttpGet("")]
        public ActionResult<IEnumerable<Report>> GetReports()
        {
            var reports = Report.GetReports();
            return Ok(reports);
        }
    }
}

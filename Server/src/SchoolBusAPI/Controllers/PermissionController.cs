/*
 * REST API Documentation for the MOTI School Bus Application
 *
 * The School Bus application tracks that inspections are performed in a timely fashion. For each school bus the application tracks information about the bus (including data from ICBC, NSC, etc.), it's past and next inspection dates and results, contacts, and the inspector responsible for next inspecting the bus.
 *
 * OpenAPI spec version: v1
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.SwaggerGen.Annotations;
using SchoolBusAPI.Models;
using SchoolBusAPI.ViewModels;
using SchoolBusAPI.Services;
using SchoolBusAPI.Authorization;

namespace SchoolBusAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public partial class PermissionController : Controller
    {
        private readonly IPermissionService _service;

        /// <summary>
        /// Create a controller and set the service
        /// </summary>
        public PermissionController(IPermissionService service)
        {
            _service = service;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        /// <response code="201">Permission created</response>
        [HttpPost]
        [Route("/api/permissions/bulk")]
        [SwaggerOperation("PermissionsBulkPost")]
        [RequiresPermission(Permission.ADMIN)]
        public virtual IActionResult PermissionsBulkPost([FromBody]Permission[] items)
        {
            return this._service.PermissionsBulkPostAsync(items);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/api/permissions")]
        [SwaggerOperation("PermissionsGet")]
        [SwaggerResponse(200, type: typeof(List<PermissionViewModel>))]
        public virtual IActionResult PermissionsGet()
        {
            return this._service.PermissionsGetAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id of Permission to delete</param>
        /// <response code="200">OK</response>
        /// <response code="404">Permission not found</response>
        [HttpPost]
        [Route("/api/permissions/{id}/delete")]
        [SwaggerOperation("PermissionsIdDeletePost")]
        public virtual IActionResult PermissionsIdDeletePost([FromRoute]int id)
        {
            return this._service.PermissionsIdDeletePostAsync(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id of Permission to fetch</param>
        /// <response code="200">OK</response>
        /// <response code="404">Permission not found</response>
        [HttpGet]
        [Route("/api/permissions/{id}")]
        [SwaggerOperation("PermissionsIdGet")]
        [SwaggerResponse(200, type: typeof(PermissionViewModel))]
        public virtual IActionResult PermissionsIdGet([FromRoute]int id)
        {
            return this._service.PermissionsIdGetAsync(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id of Permission to fetch</param>
        /// <param name="item"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Permission not found</response>
        [HttpPut]
        [Route("/api/permissions/{id}")]
        [SwaggerOperation("PermissionsIdPut")]
        [SwaggerResponse(200, type: typeof(PermissionViewModel))]
        public virtual IActionResult PermissionsIdPut([FromRoute]int id, [FromBody]PermissionViewModel item)
        {
            return this._service.PermissionsIdPutAsync(id, item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <response code="201">Permission created</response>
        [HttpPost]
        [Route("/api/permissions")]
        [SwaggerOperation("PermissionsPost")]
        [SwaggerResponse(200, type: typeof(PermissionViewModel))]
        public virtual IActionResult PermissionsPost([FromBody]PermissionViewModel item)
        {
            return this._service.PermissionsPostAsync(item);
        }
    }
}

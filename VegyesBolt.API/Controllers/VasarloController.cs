﻿// <copyright file="VasarloController.cs" company="MSanyi">
// Copyright (c) MSanyi.All rights reserved.
// </copyright>

namespace VegyesBolt.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using VegyesBolt.API.Helper;
    using VegyesBolt.Data;

    /// <inheritdoc/>.
    public class VasarloController : BaseController<Vasarlok>
    {
        /// <inheritdoc/>.
        public override void Delete(int id)
        {
            Shared.Worker.DeleteVasarlo(new Vasarlok() { Id = id });
        }

        /// <inheritdoc/>.
        public override IEnumerable<Vasarlok> Get()
        {
            return Shared.Worker.GetVasarlok();
        }

        /// <inheritdoc/>.
        public override Vasarlok Get(int id)
        {
            return Shared.Worker.GetVasarlo(id);
        }

        /// <inheritdoc/>.
        public override void Post([FromBody] Vasarlok value)
        {
            Shared.Worker.UpdateVasarlo(value);
        }

        /// <inheritdoc/>.
        public override void Put([FromBody] Vasarlok value)
        {
            if (Shared.Worker.CreateVasarlo(value))
            this.Response.StatusCode = 201;
            else
            this.Response.StatusCode = 500;
        }
    }
}